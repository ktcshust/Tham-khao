using System;
using System.Net;
using System.Windows.Controls;
using FXML;
using repository;

namespace controller
{
public class TrangChuController : Initializable
{
private Label tongNhanKhauThuongTru;
private Label tongNhanKhauTamTru;
private Label tongNhanKhauTamVang;
private Label tongHoKhauThuongTru;
    NhanKhauRepository nhanKhauRepository = new NhanKhauRepositoryImpl();
    HoKhauRepository hoKhauRepository = new HoKhauRepositoryImpl();

    public void Initialize(URL location, ResourceBundle resources)
    {
        tongNhanKhauThuongTru.setText(Convert.ToString(nhanKhauRepository.tongNhanKhauThuongTru()));
        tongNhanKhauTamTru.setText(Convert.ToString(nhanKhauRepository.tongNhanKhauTamTru()));
        tongNhanKhauTamVang.setText(Convert.ToString(nhanKhauRepository.tongNhanKhauTamVang()));
        tongHoKhauThuongTru.setText(Convert.ToString(hoKhauRepository.tongHoKhauThuongTru()));
    }
}
