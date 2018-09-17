using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharpApp
{
    public partial class MainForm : Form
    {
        #region 定数
        private const string LOCAL_HTML_ROOT_DIR = "html";
        #endregion

        #region フィールド
        private ChromiumWebBrowser _browser;
        #endregion

        #region 初期化・終了処理
        public MainForm()
        {
            InitializeComponent();

            initBrowser();
        }

        private void initBrowser()
        {
            _browser = new ChromiumWebBrowser(getLocalAddress("index.html"));
            _browser.Dock = DockStyle.Fill;
            browserPanel.Controls.Add(_browser);

            _browser.IsBrowserInitializedChanged += _browser_IsBrowserInitializedChanged;
            _browser.LoadError += _browser_LoadError;
            _browser.ConsoleMessage += _browser_ConsoleMessage;
            _browser.LoadingStateChanged += _browser_LoadingStateChanged;
            _browser.FrameLoadStart += _browser_FrameLoadStart;
            _browser.FrameLoadEnd += _browser_FrameLoadEnd;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _browser.Dispose();
            Cef.Shutdown();
        }
        #endregion

        #region ブラウザイベント
        private void _browser_IsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            Debug.WriteLine($"IsBrowserInitializedChanged:{e.IsBrowserInitialized}");
        }

        private void _browser_LoadError(object sender, LoadErrorEventArgs e)
        {
            Debug.WriteLine($"LoadError:{e.ErrorCode}");
        }

        private void _browser_ConsoleMessage(object sender, ConsoleMessageEventArgs args)
        {
            Debug.WriteLine($"ConsoleMessage Line:{args.Line}, Source:{args.Source}, Message:{args.Message}");
        }

        private void _browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            Debug.WriteLine($"LoadingStateChanged:{args.IsLoading}");
        }

        private void _browser_FrameLoadStart(object sender, FrameLoadStartEventArgs e)
        {
            Debug.WriteLine($"FrameLoadStart:{e.TransitionType}");
        }

        private void _browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Debug.WriteLine($"FrameLoadEnd:{e.HttpStatusCode}");
        }

        private string getLocalAddress(string fileName)
        {
            Uri uri = new Uri(Path.GetFullPath($"{LOCAL_HTML_ROOT_DIR}/{fileName}"));
            return uri.AbsoluteUri;
        }
        #endregion

        #region デバッグ用メソッド
        private void debugGotoIndexButton_Click(object sender, EventArgs e)
        {
            _browser.Load(getLocalAddress("index.html"));
        }
        #endregion
    }
}
