namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => $"Versión: {AppInfo.VersionString}";
    
    public string MoreInfoUrl => "https://github.com/Axelzu/TALLERCREACIONDEAPUNTES.git"; 

    public string Message => "Hola,Mi nombre es Alexander Cahueñas, estudio en la udla. Esta app fue desarrollada como parte del curso de desarrollo móvil con NET MAUI. Me interesa la programación  y sobre todo la creacion de videojuegos.";
}