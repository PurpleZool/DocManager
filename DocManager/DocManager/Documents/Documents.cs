using DocManager.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DocManager.Documents
{
    [Serializable]
    public class Document
    {


        [JsonIgnore]
        public string Extension { get { return Path.GetExtension(PathRaw); } }
        [JsonIgnore]
        public string FileName { get { return Path.GetFileName(PathRaw); } }
        [JsonIgnore]
        public string Name { get { return Path.GetFileNameWithoutExtension(PathRaw); } }
        [JsonIgnore]
        public string Directory { get { return Path.GetDirectoryName(PathRaw); } }
        [JsonIgnore]
        public string TagString { get { return string.Join(", ",Tags); } }

        [JsonIgnore]
        public Response Status { get; set; } 

        public int Idx { get; set; }
        public string Hash { get; set; }
        public string PathRaw { get; set; }
        public string Title { get; set; }
        public List<string> Tags { get; set; }


        public Document(string path,string title, List<string>tags, int Idx) 
        {
            this.Idx = Idx;
            this.Title = title;
            this.PathRaw = path;
            this.Tags = tags;
            this.Hash = !File.Exists(path) ? string.Empty:CalculateHash(HashAlgorithmName.SHA256);
            this.Status = Response.OK;
        }

        public Document(string path) : this(path, string.Empty, new List<string>(),0)
        {
        }

        public Document() : this(string.Empty) 
        {
        
        }

        public string CalculateHash(HashAlgorithmName hashName) 
        {
            FileStream fs = new FileStream(PathRaw, FileMode.Open, FileAccess.Read);
            HashAlgorithm hasher = HashAlgorithm.Create(hashName.Name);
            byte[] hashBytes = hasher.ComputeHash(fs);
            fs.Close();
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
    }

    public class DocumentHandler 
    {
        public List<Document> Documents { get; set; }
    



        public DocumentHandler() 
        {
            Documents = new List<Document>();
        }

        public DocumentHandler(List<Document> documents) 
        {
            documents = new List<Document>(documents);
        }


        public void AddDocument(string docPath,string title,List<string> tags) 
        {
            Document newDoc = new Document(docPath, title, tags, GetLastIndex());
            AddDocument(newDoc);
        }

        public void AddDocument(Document document) 
        {
            Documents.Add(document);
        
        }

        public int GetLastIndex() 
        {
            int highValue = 0;
            foreach(Document currentDoc in Documents) 
            {
                if (currentDoc.Idx > highValue) highValue = currentDoc.Idx;    
            }
            return highValue + 1;
        }

        public Document GetDocumentByIdx(int idx) 
        {
            return Documents.FirstOrDefault(d => d.Idx == idx);
        }
        public Document GetDocumentByIdx(string idxStr) 
        {
            int idx = 0;
            int.TryParse(idxStr, out idx);
            return GetDocumentByIdx(idx);
        }

        public List<Document> GetDocumentsByTags(string tag1, string tag2, bool isAnd) 
        {
            List<Document> selectedDocs = new List<Document>();

            if ((tag1 != string.Empty) && (tag2 == string.Empty))
            {
                foreach (Document currentDoc in Documents)
                {
                    if (currentDoc.Tags.Contains(tag1)) selectedDocs.Add(currentDoc);
                }
            }
            else 
            {
                foreach (Document currentDoc in Documents)
                {
                    if (isAnd)
                    {
                        if (currentDoc.Tags.Contains(tag1) && currentDoc.Tags.Contains(tag2)) selectedDocs.Add(currentDoc);
                    }
                    else 
                    {
                        if (currentDoc.Tags.Contains(tag1) || currentDoc.Tags.Contains(tag2)) selectedDocs.Add(currentDoc);
                    }
                }
            
            }
            return selectedDocs;
        }

        public void Save(string savePath) 
        {
            string json = JsonConvert.SerializeObject(Documents);
            System.IO.File.WriteAllText(savePath, json);
        }

        public List<Document> Load(string filePath) 
        {
            List<Document> documents = new List<Document>();
            string json = System.IO.File.ReadAllText(filePath);
            documents = JsonConvert.DeserializeObject<List<Document>>(json);
            return documents;
        }

        public void CheckDocument(Document document) 
        {
            if (File.Exists(document.PathRaw)) 
            {
                if(document.Hash == document.CalculateHash(HashAlgorithmName.SHA256)) 
                {
                    document.Status = Response.OK;

                }
                else 
                {
                    document.Status = Response.DOCUMENT_CHANGED;
                }
            }
            else 
            {
                document.Status = Response.NOT_PRESENT;
            }
        }


        public void CheckDocuments() 
        {
            foreach(Document document in Documents) 
            {
                CheckDocument(document); 
            }
        }

    }


}
