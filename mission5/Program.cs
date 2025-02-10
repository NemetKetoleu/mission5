var builder = WebApplication.CreateBuilder(args);

// Set up services for the application 
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Enables the use of default files like 'index.html' for routing, so the user doesn't need to specify the file explicitly in the URL.
//app.UseDefaultFiles(); // We use this so that we don't always have to add '/index.html' on the page whenever we run the code. It uses our index.html as the default file

//in case user types http, it redirects the HTTP requests to HTTPS to ensure secure communication over the network.
app.UseHttpsRedirection();

// Allows the website to show static files like images, styles, and scripts from the "wwwroot" folder.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Defines the default routing pattern for controllers, setting 'Home' as the default controller and 'price' as the default action. The 'id' parameter is optional.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=price}/{id?}" // The default controller is 'Home', the default action is 'price', and 'id' is optional
);

// Starts the application and listens for incoming HTTP requests.
app.Run();
