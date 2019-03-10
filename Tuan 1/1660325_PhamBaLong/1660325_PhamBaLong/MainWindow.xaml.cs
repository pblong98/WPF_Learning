using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1660325_PhamBaLong
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string[] dongluc = new string[10];
		string[] theduc = new string[10];
		string[] anhviet = new string[10];
		public MainWindow()
		{
			InitializeComponent();
			dongluc[0] = "Không gì là không thể";
			dongluc[1] = "Để có thể thành công, bạn buộc phải tin rằng bạn có thể";
			dongluc[2] = "Nghĩ quá nhiều sẽ hủy hoại bạn. Hủy hoại thực tại, thay đổi mọi thứ xung quanh, khiến bạn lo lắng và làm mọi thứ trở nên tồi tệ hơn bạn nghĩ";
			dongluc[3] = "Hãy luyện tập như thể bạn chưa bao giờ chiến thắng. Hãy hành động như thể chưa bao giờ bạn thất bại";
			dongluc[4] = "Chỉ cần bạn không dừng lại thì việc bạn tiến chậm cũng không là vấn đề";
			dongluc[5] = "Bất kỳ ai cố gắng ''dìm'' bạn xuống thì họ đều thua kém bạn";
			dongluc[6] = "Cách để bắt đầu đó là dừng việc nói lại và hãy bắt đầu làm";
			dongluc[7] = "Hãy lắng nghe một cách cẩn thận điều người khác nói với bạn về một ai đó. Đấy chính là cách mà họ sẽ nói với ai đó về bạn";
			dongluc[8] = "Giữ đôi mắt của bạn hướng lên bầu trời và đôi chân trên mặt đất";
			dongluc[9] = "Có hai điều cần nhớ trong cuộc sống: Hãy chăm sóc suy nghĩ của bạn khi bạn một mình và hãy cẩn trọng với lời nói khi ở chốn đông người";

			theduc[0] = "Hít đất 1000 cái";
			theduc[1] = "Chạy 1000 KM";
			theduc[2] = "Gập bụng 1000 lần";
			theduc[3] = "Đẩy tạ 1000 Kg";
			theduc[4] = "Chạy bộ 1000 Km";
			theduc[5] = "Nhảy dây trong 1000 cái";
			theduc[6] = "Đi bộ liên tục 1000 Km";
			theduc[7] = "Hít xà đơn 1000 phát";
			theduc[8] = "Nhảy cao 1000 Km";
			theduc[9] = "Nhảy cao 100000 Km";

			anhviet[0] = "Hello - Xin chào";
			anhviet[1] = "Hi - chào";
			anhviet[2] = "How - Như thế nào";
			anhviet[3] = "Are - Là";
			anhviet[4] = "You - Bạn";
			anhviet[5] = "I(am) - Tôi";
			anhviet[6] = "fine - Khỏe mạnh";
			anhviet[7] = "thank - cảm ơn";
			anhviet[8] = "you - bạn";
			anhviet[9] = "and - và";
		}

		int random()
		{
			Random TenBienRanDom = new Random();
			int kq = TenBienRanDom.Next(0, 9);//Trả về giá trị kiểu int
			return kq;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(dongluc[random()]);
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(theduc[random()]);
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(anhviet[random()]);
		}
	}
}
