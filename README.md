# Route
- - -
## Attribute Routing  

加入 `[Route]` 到 Controller：

```cs
[Route("books")]
[ApiController]
public class BooksController : ControllerBase
{
    // GET: /Books
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<Book>>> GetBook() { ... }
    
    // GET: /Books/5
    [HttpGet()]
    [Route("{id:int}")]
    public async Task<ActionResult<Book>> GetBook(int id) { ... }
    
    // 使用Router才能支援 RESTful API 中常見的某些 URI 模式
    // 查詢特定 Author
    // GET: authors/{authorId}/books
    [HttpGet]
    [Route("~/authors/{authorId:int}/books")]
    public IActionResult GetBooksByAuthor(int authorId) { ... }
    
    // GET: /books/date/2016-06-27
    [HttpGet]
    //[Route("date/{publishDate:datetime}")]
    //[Route("date/{publishDate:datetime:regex(\d{{4}}-\d{{2}}-\d{{2}})}")]
    [Route(@"date/{publishDate:datetime:regex(\d{{4}}-\d{{2}}-\d{{2}})}")]
    public IActionResult Get(DateTime publishdate) { ... }
}
```

使用 [RoutePrefix] 屬性為整個控制器設定公共前置前置字串:
```cs
[RoutePrefix("api/books")]
public class BooksController : ApiController
{
    // GET api/books
    [Route("")]
    public IEnumerable<Book> Get() { ... }

    // GET api/books/5
    [Route("{id:int}")]
    public Book Get(int id) { ... }

    // POST api/books
    [Route("")]
    public HttpResponseMessage Post(Book book) { ... }
}
```
- - -
## Map動詞()

* 判斷請求來源的資訊(例如瀏覽器)  
    ```cs
    app.Use((context, next) =>
    {
        var userAgent = context.Request.Headers["User-Agent"].ToString();
        //只允許Postman通過
        if (userAgent.Contains("Postman"))
        {
         return next();
        }
        else
        {
         return context.Response.WriteAsync("Error");
        }
    });
    ```  
* 建立 Middleware 類別  
    把自製的 Middleware 邏輯獨立出來。
    自製的Middleware中要有一個非同步的 Invoke 方法。
    ```cs
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;
    
        public SampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }
    
        public async Task Invoke(HttpContext context)
        {
            var userAgent = context.Request.Headers["User-Agent"].ToString();
            if (userAgent.Contains("Postman"))
            {
                await _next(context);
            }
            else
            {
                await context.Response.WriteAsync("Error");
            }
        }
    }
    ```  
    
- - -
參考資料：   
**精準解析 ASP.NET Core Web API**  
<a href="https://docs.microsoft.com/zh-tw/aspnet/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api" target="_blank">ASP.NET Web API 中的路由</a>  
<a href="https://docs.microsoft.com/zh-tw/aspnet/web-api/overview/web-api-routing-and-actions/routing-and-action-selection" target="_blank">ASP.NET Web API 中的路由和動作選取</a>  
<a href="https://docs.microsoft.com/zh-tw/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2" target="_blank">ASP.NET Web API 2 中的屬性路由</a>
<a href="https://blog.johnwu.cc/article/ironman-day03-asp-net-core-middleware.html" target="_blank">[鐵人賽 Day03] ASP.NET Core 2 系列 - Middleware</a>
- - -
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
    
