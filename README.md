# Route
## Attribute Routing  

---
* 新增 Web API Controller  
    於 Add Scaffold → 選擇：Web API 2 Controller with actions, using Entity Framework
    * Model class: Book
    * Controller name: BooksController
    * Data context class: 選擇 + 號：BookSampleContext  
* 如果使用空白專案，要在Startup.cs新增  
    ```csharp  
        public IConfiguration Configuration { get; }
    
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
* 開啟 **Package Manager Console**，輸入以下指令：  
    ```csharp
    PM> Add-Migration initial
    ```