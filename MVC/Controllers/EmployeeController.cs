using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller {
    public IActionResult IndexEmployee(){
        return View();
    }
    [HttpPost]
    public IActionResult IndexEmployee(string hoTen, decimal luongCoBan, decimal heSoLuong, decimal phuCap){
        decimal luong = luongCoBan + heSoLuong + phuCap;
        string tinhLuong = hoTen + "-" + luong;
        ViewBag.thongbao = tinhLuong;
        return View();
    }
}
// Nguyen Minh Quan