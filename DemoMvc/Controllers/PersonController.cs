using DemoMvc.Person;
using Microsoft.AspNetCore.Mvc;

public class PersonController : Controller
{
    public IActionResult IndexPerson()
    {
        return View();
    }
    [HttpPost]
    public IActionResult IndexPerson(Person ps)
    {
        string strResult = ps.PersonID + "-" + ps.FullName;
        ViewBag.capnhat = strResult;    
        return View();
    }
}
