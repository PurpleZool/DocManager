using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DocManager.Components
{
    public class FileFinder
    {

        string pathToSearch;
        bool recursiveSearch;
        string hash;
        string extension;

        Thread searchThread;

        public delegate void ItemFound(string item);
        public event ItemFound AddFound;

        public delegate void FinderErrorMessage(string message);
        public event FinderErrorMessage ErrorMessage;


        public bool Running { get { return searchThread.ThreadState == ThreadState.Running; } }

        public FileFinder(string startPath,string hash, bool recursive) 
        {
            this.pathToSearch = startPath;
            this.recursiveSearch = recursive;
            this.hash = hash;
        }

        public FileFinder(string startPath,string hash,string extension,bool recursive) : this(startPath,hash,recursive) 
        {
            this.extension = extension;
        }

        public void StartSearch() 
        {
            try
            {
                MainSearch(pathToSearch);
            }catch(Exception ex) 
            {
                ErrorMessage?.Invoke(ex.Message);
            }
        }

        private void MainSearch(string folderPath) 
        {
            FolderSearch(folderPath);
            if (recursiveSearch) 
            {
                foreach (string newPath in Directory.GetDirectories(folderPath)) 
                {
                    MainSearch(newPath);
                }
            }
        }

        private void FolderSearch(string folderPath) 
        {
            foreach(string currentFile in Directory.GetFiles(folderPath)) 
            {
                if (extension != null && extension != string.Empty && Path.GetExtension(currentFile).ToLower() != extension) continue;
                if (hash != null && hash != string.Empty && CalculateHash(HashAlgorithmName.SHA256,currentFile) != hash) continue;
                AddFound?.Invoke(currentFile);
            }
        }

        public string CalculateHash(HashAlgorithmName hashName, string filePath) 
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            HashAlgorithm hasher = HashAlgorithm.Create(hashName.Name);
            byte[] hashBytes = hasher.ComputeHash(fs);
            fs.Close();
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }




    }
}
