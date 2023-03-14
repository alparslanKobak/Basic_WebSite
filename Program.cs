var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // Uygulama http isteklerini https ile g�venli ba�lant�ya y�nlendirmeyi desteklesin.

app.UseStaticFiles(); // uygulama statik dosyalar� (wwwroot klas�r�ndekiler) desteklesin.

app.UseRouting(); // uygulama routing ile y�nlendirmeyi kullans�n.

app.UseAuthentication(); // Uygulama kullan�c� giri� sistemini aktifle�tirsin.

app.UseAuthorization(); // uygulama kullan�c� yetkilendirme (admin, user vb.) sistemini aktif etsin.

app.MapControllerRoute( // uygulaman�n kullanaca�� routing y�nlendirme ayar�

    name: "default", // rouute ad�
    pattern: "{controller=Home}/{action=Index}/{id?}"); // e�er adres �ubu�undan uygulamaya bir controller ad� ve action ad� g�nderilmezse varsay�lan olarak home controller� ve i�indeki index isimli action � �al��t�r�ls�n. Id de�eri ise ? i�areti ile parametrik yani iste�e ba�l� belirtilmi�.

app.Run(); // uygulamay� yukar�daki ayarlar� kullanarak �al��t�r.
