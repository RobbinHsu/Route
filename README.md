# Route
## Attribute Routing  




---
* 如果使用空白專案，要在Startup.cs新增
    * Configuration  
        ```csharp  
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        ```
    
    * ServiceCollection 
        ```csharp  
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        ```  
    
    * endpoints.MapControllers();
        ```csharp  
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        ```
* 新增 Web API Controller  
    於 Add Scaffold → 選擇：Web API 2 Controller with actions, using Entity Framework
    * Model class: Book
    * Controller name: BooksController
    * Data context class: 選擇 + 號：BookSampleContext  

* 加入SeedDate
    * 開啟 **Package Manager Console**，輸入以下指令：  
        ```csharp
        PM> Add-Migration initial
        ```
    * 在 DbContext 衍生類別覆寫 OnModelCreating()，加入SeedData。  
    * 輸入以下指令，Migrations資料夾就會產生SeedData  
        ```csharp 
        PM> Add-Migration seeddata  
        PM> Update-Database  
        ```
    
