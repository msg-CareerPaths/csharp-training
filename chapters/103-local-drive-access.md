## 1.3. Local drive access 

**Goal:** Understand IO Operations and JSON Serialization 

**Required reading:**

 - [Serialize JSON using System.Text.Json](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-7-0)
 - [How to create a file or folder](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-create-a-file-or-folder)
 - [How to copy, delete, and move files and folders](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-copy-delete-and-move-files-and-folders)
 - [How to write to a text file](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file)
 - [How to read from a text file](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file)

**Exercise:**

  Update the application to save products as files.  
  Update the existing products controller and service or create new ones as you wish.  
  Add methods to create,update,get an delete products as json files from\to disk.  
  You must take into consideration the followings:  
  - Products must be stored as json files.  
  - Every time a product is created a file must be created on disk with information about the product.   
  - When a product is modified or deleted, this must reflect in the files saved on disk.  
  - You will have to come up with an apropiate folder and file name for this task.  
  - The folder where the files are stored does not exists.The folder can be located where you want.  
  
 **Further Resources:**
 
 - [An alternative for serialization is Newtonsoft.Json](https://www.youtube.com/watch?v=hLYHE1kIOpo)  
 - [Comparison of System.Text.Json and Newtonsoft.Json(Newtonsoft.Json is a library used for JSON serialization in older projects)](https://inspiration.nlogic.ca/en/a-comparison-of-newtonsoft.json-and-system.text.json)  
 - [More about File system can be found here](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/)  
 - [File and Stream I/O](https://docs.microsoft.com/en-us/dotnet/standard/io/)  
