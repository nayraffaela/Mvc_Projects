using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Retorna a view para a página inicial
    }

    public IActionResult Jogo()
    {
        return View(); // Retorna a view para a página de jogos
    }

    public IActionResult Privacy()
    {
        return View(); // Retorna a view para a página de privacidade
    }

    public IActionResult Contato()
    {
        return View(); // Retorna a view para a página de contato
    }
    public IActionResult Guias()
    {
        return View();
    }
}
