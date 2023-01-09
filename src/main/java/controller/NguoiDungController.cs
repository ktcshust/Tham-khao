using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using javafx.event;
using javafx.fxml;
using javafx.scene;
using javafx.scene.control;
using javafx.scene.layout;
using javafx.stage;
using repository;
using repository.NguoiDungRepositoryImpl;
using utility;
using view;

namespace controller
{
    public class NguoiDungController
    {
        public Button HuyButton { get; set; }
        public Button DangNhapButton { get; set; }
        public TextField TaiKhoan { get; set; }
        public PasswordField MatKhau { get; set; }
        public Label DangNhapThatBaiMessage { get; set; }

        static NguoiDungRepository NguoiDungRepository = new NguoiDungRepositoryImpl();

        public void HuyButtonOnAction(ActionEvent event)
        {
            Stage stage = (Stage)HuyButton.getScene().getWindow();
            stage.close();
        }

        public void DangNhapButtonOnAction(ActionEvent event)
        {
            if (TaiKhoan.getText().isBlank() == false && MatKhau.getText().isBlank() == false)
            {
                if (NguoiDungRepository.dangNhap(TaiKhoan.getText(), MatKhau.getText()))
                {
                    Stage stage = (Stage)DangNhapButton.getScene().getWindow();

                    FXMLLoader fxmlLoader = new FXMLLoader(Main.class.getResource("manHinhChinh.fxml"));
                    Scene scene = new Scene(fxmlLoader.load());

                    stage.setTitle("Quản lý khu phố");
                    stage.setScene(scene);
                    stage.setWidth(1400);
                    stage.setHeight(780);
                    stage.setX(10);
                    stage.setY(10);
                    stage.show();
                }
                else
                {
                    DangNhapThatBaiMessage.setText(Message.dangNhapThatBai);
                }
            }
            else
            {
                DangNhapThatBaiMessage.setText(Message.dangNhapTrong);
            }
        }
    }
}
