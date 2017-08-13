using Microsoft.Toolkit.Uwp.UI.Animations;
using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using System.Collections.Specialized;
using Windows.System;
using System.IO;
using System.Runtime.Serialization;
using System.Net.Sockets;
using System.Text;
using System.Net;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChatAppUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Content lastChat = new Content(id: "", name: "", content: "", image: "", hide: "Collapsed", height: "0", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Collapsed", horizonalign: "Left");
        public ObservableCollection<Contact> listContact = new ObservableCollection<Contact>
        {
            new Contact(id:"USER1047383",name:"Alex",content:"Đang làm gì???",image:"60838637_p2_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Sandra",content:"Đang ở đâu???",image:"60838637_p12_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Mohamed",content:"Đang tắm.",image:"60838637_p11_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Andy",content:"Đang làm gì???",image:"60838637_p2_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Mikasa",content:"Đang tắm.",image:"60838637_p7_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Vladimir",content:"Đang ở đâu???",image:"60838637_p2_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Calem",content:"Đang làm gì???",image:"60838637_p7_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Leo",content:"Đang ở đâu???",image:"60838637_p11_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Qitipie",content:"Đang tắm.",image:"60838637_p2_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Oldimz",content:"Đang làm gì???",image:"60838637_p12_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Szavech",content:"Đang làm gì???",image:"60838637_p12_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Eiona",content:"Đang ở đâu???",image:"60838637_p2_master1200.jpg"),
            new Contact(id:"USER1047383",name:"Kokashi",content:"Đang tắm.",image:"60838637_p11_master1200.jpg")

        };

        public static ObservableCollection<Content> listContent = new ObservableCollection<Content>
        {
            new Content(id:"USER1047383",name:"Alex",content:"Đang làm gì???",image:"60838637_p2_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Sandra",content:"Đang ở đâu???",image:"60838637_p12_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Mohamed",content:"Đang tắm.",image:"60838637_p11_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Andy",content:"Đang làm gì???",image:"60838637_p2_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Mikasa",content:"Đang tắm.",image:"60838637_p7_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Vladimir",content:"Đang ở đâu???",image:"60838637_p2_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Calem",content:"Đang làm gì???",image:"60838637_p7_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Leo",content:"Đang ở đâu???",image:"60838637_p11_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Qitipie",content:"Đang tắm.",image:"60838637_p2_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Oldimz",content:"Đang làm gì???",image:"60838637_p12_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Szavech",content:"Đang làm gì???",image:"60838637_p12_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047383",name:"Eiona",content:"Đang ở đâu???",image:"60838637_p2_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"),
            new Content(id:"USER1047333",name:"Kokashi",content:"Đang tắm.",image:"60838637_p11_master1200.jpg", hide:"Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left")

        };

        bool isTextNull = true;
        Content contentSe;
        Content contentDese;
        byte[] bytesSe;
        Socket client;
        private const int BUFFER_SIZE = 8192;
        private const int PORT_NUMBER = 9123;
        static ASCIIEncoding encoding = new ASCIIEncoding();

        public MainPage()
        {
            this.InitializeComponent();
            applyAcrylicAccent(MainGrid);
            ApplicationViewTitleBar formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonForegroundColor = Color.FromArgb(255, 30, 30, 30);
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            formattableTitleBar.ButtonHoverBackgroundColor = Color.FromArgb(20, 0, 0, 0);
            formattableTitleBar.ButtonPressedBackgroundColor = Color.FromArgb(50, 0, 0, 0);
            formattableTitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
            Window.Current.Activated += Current_Activated;
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, a) =>
            {
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    a.Handled = true;
                }
            };
            listViewContact.ItemsSource = listContact;
            HamburgerMenu.SelectedIndex = 0;
            listViewContent.ItemsSource = listContent;
            ((INotifyCollectionChanged)listContent).CollectionChanged += ListView_CollectionChangedAsync;
            listContent.Add(lastChat);

            //connectServer();
        }

        private void connectServer()
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), PORT_NUMBER);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(iep);
            client.Send(encoding.GetBytes("USER1047333"));
        }

        private void applyAcrylicAccent(Panel panel)
        {
            _compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
            _hostSprite = _compositor.CreateSpriteVisual();
            _hostSprite.Size = new Vector2((float)panel.ActualWidth, (float)panel.ActualHeight);

            ElementCompositionPreview.SetElementChildVisual(panel, _hostSprite);
            _hostSprite.Brush = _compositor.CreateHostBackdropBrush();
        }
        Compositor _compositor;
        SpriteVisual _hostSprite;

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (_hostSprite != null)
                _hostSprite.Size = e.NewSize.ToVector2();

            if (HamburgerMenu.IsPaneOpen == true)
                HamburgerMenu.IsPaneOpen = false;
        }

        private void Current_Activated(object sender, WindowActivatedEventArgs e)
        {
            if (e.WindowActivationState == CoreWindowActivationState.Deactivated)
            {
                grid.Background = new SolidColorBrush(Color.FromArgb(255, 220, 220, 220));
            }
            else
            {
                grid.Background = new SolidColorBrush(Color.FromArgb(120, 255, 255, 255));
            }
        }

        private void HamburgerMenu_OnItemClick(object sender, ItemClickEventArgs e)
        {
            ContentGrid.DataContext = e.ClickedItem;
        }

        private async void HamburgerMenu_OnOptionsItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = e.ClickedItem as HamburgerMenuItem;
            var dialog = new MessageDialog($"You clicked on {menuItem.Label} button");

            await dialog.ShowAsync();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            gridEdgeBlur.Visibility = Visibility.Visible;
            gridEdgeBlur.Fade(value: 1f, duration: 100, delay: 0).StartAsync();
            Expand.Begin();
        }

        private async void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Collapse.Begin();
            await gridEdgeBlur.Fade(value: 0f, duration: 100, delay: 0).StartAsync();
            gridEdgeBlur.Visibility = Visibility.Collapsed;
        }

        private void gridEdge_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            colContent.Width = new GridLength(348 - e.NewSize.Width);
        }

        private void gridEdgeBlur_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (HamburgerMenu.IsPaneOpen == true)
                HamburgerMenu.IsPaneOpen = false;
        }

        private async void listViewContact_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await titleChating.Offset(offsetX: 0f,
                            offsetY: -10f,
                            duration: 0, delay: 0).StartAsync();
            await titleChating.Offset(offsetX: 0f,
                         offsetY: 0f,
                         duration: 400, delay: 0).StartAsync();

        }

        private void btnSend_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (!isTextNull)
                btnSend.Background = new SolidColorBrush(Color.FromArgb(125, 214, 155, 220));
        }

        private void btnSend_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (!isTextNull)
                btnSend.Background = new SolidColorBrush(Color.FromArgb(125, 255, 175, 255));
        }

        private void txtContentSend_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textSend = txtContentSend.Text.Replace("\r", "");
            if (textSend != "")
            {
                btnSend.Background = new SolidColorBrush(Color.FromArgb(125, 255, 175, 255));
                isTextNull = false;
            }
            else
            {
                btnSend.Background = new SolidColorBrush(Color.FromArgb(25, 0, 0, 0));
                isTextNull = true;
            }

        }

        public static DependencyObject GetScrollViewer(DependencyObject o)
        {
            if (o is ScrollViewer)
            { return o; }

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(o); i++)
            {
                var child = VisualTreeHelper.GetChild(o, i);

                var result = GetScrollViewer(child);
                if (result == null)
                {
                    continue;
                }
                else
                {
                    return result;
                }
            }
            return null;
        }

        private void OnScrollDown()
        {
            ScrollViewer scrollViewer = GetScrollViewer(listViewContent) as ScrollViewer;

            if (scrollViewer != null)
            {
                scrollViewer.ChangeView(0, scrollViewer.ScrollableHeight, 1);
            }
        }

        private async void ListView_CollectionChangedAsync(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                await Task.Delay(20);
                OnScrollDown();
            }
        }

        public void AddContentChat(string id, string name, string content, string image)
        {
            if (listContent[listContent.Count - 2].Id == id)
            {
                if (listContent[listContent.Count - 3].Id == id)
                {
                    listContent[listContent.Count - 2].Radius = "7, 0, 0, 7";
                }
                else
                {
                    listContent[listContent.Count - 2].Radius = "7, 6, 0, 7";
                }
                listContent.Insert(listContent.Count - 1, new Content(id: id, name: name, content: content, image: image, hide: "Visible", height: "Auto", timerow: "0", radius: "7, 0, 7, 7", imagevisibility: "Collapsed", horizonalign: "Right"));
            }
            else
            {
                listContent.Insert(listContent.Count - 1, new Content(id: id, name: name, content: content, image: image, hide: "Visible", height: "Auto", timerow: "16", radius: "7, 0, 7, 7", imagevisibility: "Collapsed", horizonalign: "Right"));

            }
        }

        public void GetContentChat(string id, string name, string content, string image)
        {
            if (listContent[listContent.Count - 2].Id == id)
            {
                if (listContent[listContent.Count - 3].Id == id)
                {
                    listContent[listContent.Count - 2].Radius = "0, 7, 7, 0";
                }
                else
                {
                    listContent[listContent.Count - 2].Radius = "7, 7, 7, 0";
                }
                listContent.Insert(listContent.Count - 1, new Content(id: id, name: name, content: content, image: image, hide: "Visible", height: "Auto", timerow: "0", radius: "0, 7, 7, 7", imagevisibility: "Collapsed", horizonalign: "Left"));
            }
            else
            {
                listContent.Insert(listContent.Count - 1, new Content(id: id, name: name, content: content, image: image, hide: "Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left"));

            }
        }

        private void btnSend_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SendContent();
        }

        private void txtContentSend_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                if (Window.Current.CoreWindow.GetKeyState(VirtualKey.Shift).HasFlag(CoreVirtualKeyStates.Down))
                {
                    int cursorPos = txtContentSend.SelectionStart;
                    txtContentSend.Text = txtContentSend.Text.Insert(cursorPos, "\r");
                    txtContentSend.SelectionStart = cursorPos + 1;
                }
                else
                    SendContent();
            }
        }

        public void SendContent()
        {
            if (!isTextNull)
            {
                string textSend = txtContentSend.Text;
                while (textSend.Substring(textSend.Length - 1, 1) == "\r")
                {
                    textSend = textSend.Substring(0, textSend.Length - 1);
                }
                contentSe = new Content(id: "USER1047333", name: "Kokashi", content: textSend, image: "60838637_p11_master1200.jpg", hide: "Visible", height: "Auto", timerow: "16", radius: "0, 7, 7, 7", imagevisibility: "Visible", horizonalign: "Left");
                bytesSe = SerializeData(contentSe);
                AddContentChat("USER1047908", "Kokashi", textSend, "60838637_p11_master1200.jpg");
                txtContentSend.Text = "";
            }
        }

        private void btnFile_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //string textSend = txtContentSend.Text;
            //while (textSend.Substring(textSend.Length - 1, 1) == "\r")
            //{
            //    textSend = textSend.Substring(0, textSend.Length - 1);
            //}
            //GetContentChat("USER1047333", "Kokashi", "Đang làm nà...", "60838637_p11_master1200.jpg");

            contentDese = (Content)DeserializeData(bytesSe);
            GetContentChat("USER1047333", contentDese.Name, contentDese.ContentChat, "60838637_p11_master1200.jpg");
        }


        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            DataContractSerializer serializer = new DataContractSerializer(typeof(Content));
            serializer.WriteObject(ms, o);
            return ms.ToArray();
        }


        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            ms.Position = 0;
            DataContractSerializer serializer = new DataContractSerializer(typeof(Content));
            Content content = (Content)serializer.ReadObject(ms);
            return content;
        }
    }
}
