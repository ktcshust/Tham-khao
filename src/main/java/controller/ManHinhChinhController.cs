using System;
using System.IO;
using System.Net;
using System.Windows;
using

System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Controller
{
public class ManHinhChinhController : Initializable
{
public BorderPane borderPane { get; set; }
public Pane tieuDePane { get; set; }
public Label tieuDeText { get; set; }
public Button trangChuButton { get; set; }
public Button nhanKhauButton { get; set; }
public Button hoKhauButton { get; set; }
public Button phanThuongButton { get; set; }
public Button thongKeButton { get; set; }
public Button dangXuatButton { get; set; }
public Pane mainPane { get; set; }
    public void Initialize(Uri location, ResourceDictionary resources)
    {
        Pane trangChuPane = FXMLLoader.Load(Main.GetType().GetResource("trangChu.fxml"));
        mainPane.Children.Add(trangChuPane);
    }

    public void ResetButtonBackground()
    {
        trangChuButton.Style = "-fx-background-color: #2F333D;";
        nhanKhauButton.Style = "-fx-background-color: #2F333D;";
        hoKhauButton.Style = "-fx-background-color: #2F333D;";
        phanThuongButton.Style = "-fx-background-color: #2F333D;";
        thongKeButton.Style = "-fx-background-color: #2F333D;";
    }

    public void TrangChuButtonOnAction(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        trangChuButton.Style = "-fx-background-color: #757C95;";

        Pane trangChuPane = FXMLLoader.Load(Main.GetType().GetResource("trangChu.fxml"));
        mainPane.Children.Add(trangChuPane);
    }

    public void NhanKhauButtonOnAction(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        nhanKhauButton.Style = "-fx-background-color: #757C95;";

        Pane trangChuPane = FXMLLoader.Load(GetType().GetResource("/view/nhanKhau/nhanKhau.fxml"));
        mainPane.Children.Add(trangChuPane);
    }

    public void HoKhauButtonOnAction(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        hoKhauButton.Style = "-fx-background-color: #757C95;";

        Pane trangChuPane = FXMLLoader.Load(GetType().GetResource("/view/hoKhau/hoKhau.fxml"));
        mainPane.Children.Add(trangChuPane);
    }

    public void PhanThuongButtonOnAction(object sender, RoutedEventArgs e)
    {
        ResetButtonBackground();
        phan
