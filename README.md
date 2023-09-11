# DocManager
Simple desktop application capable of managing various computer files using tags and signatures, capable of detecting changes in documents as well as searching for different files.

## Resume
- File list management
- Data saving and loading
- User configuration
- SHA256 hashing
- File search

## App Overview

The documents to be added can be selected using the button or dragged onto the form. They can be added along with the desired title or tags in a list, where their path, signature, and last known state will also be displayed.

Different states will differentiate:

- OK: Present without changes.
- NOT_PRESENT: The file is not found.
- DOCUMENT_CHANGED: The file has changed compared to the version saved by the application.

![image](https://github.com/PurpleZool/DocManager/assets/25660829/82f71b60-1693-4e2e-9ecb-c79a17750778)


Various actions can be performed with the files in the list through a context menu that opens with the right-click as:

- Copy / Update signature.
- Open File / Folder
- Check File
- File Details

### Data Save & Load
The file lists can be saved and loaded in JSON format with the .LDM extension. Users can also configure different loading options from the preferences, as well as a default save file.

![image](https://github.com/PurpleZool/DocManager/assets/25660829/2e4ae90d-45f6-420c-b487-046cf9b52f91)

### File Finder

Very simple file search tool for locating files in a specified path based on their signature and extension.

![image](https://github.com/PurpleZool/DocManager/assets/25660829/3ac28659-e01d-4dfb-8c0d-a2a59388123d)

