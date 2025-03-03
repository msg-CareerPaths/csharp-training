## 3.3. Working with files

**Goal:** Understand IO Operations and JSON Serialization 

**Required Reading:**

 - [Serialize JSON using System.Text.Json](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-7-0)
 - [How to create a file or folder](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder)
 - [How to copy, delete, and move files and folders](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-copy-delete-and-move-files-and-folders)
 - [How to write to a text file](https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file)
 - [How to read from a text file](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file)

**Exercise:**

  Create a new controller and service to save products in files.    
  Add methods to create,update,get and delete products as\from json files from\to disk.  
  You must take into consideration the followings:  
  - use System.Text.Json package for serialization and deserialization.   
  - Products must be stored as json files.  
  - Every time a product is created a file must be created on disk with the serialized information about the product.     
  - When a product is modified or deleted, this must be reflected to the files on the disk.   
  - You will have to come up with an appropiate file and folder name for this task.  
  - The folder where the files are stored does not exists, must be created from the app.   
  
 **Further Resources:**
 
 - [Comparison of System.Text.Json and Newtonsoft.Json(Newtonsoft.Json is a library used for JSON serialization in older projects)](https://inspiration.nlogic.ca/en/a-comparison-of-newtonsoft.json-and-system.text.json)  
 - [More about File system can be found here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/)  
 - [File and Stream I/O](https://docs.microsoft.com/en-us/dotnet/standard/io/)  
