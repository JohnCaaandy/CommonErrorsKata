using System;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonErrors.Shared;

namespace CommonErrorsKata
{
    public partial class CommonErrorsForm : Form
    {
        private readonly AnswerQueue<TrueFalseAnswer> _answerQueue;
        private readonly string[] _files;
        private readonly SynchronizationContext _synchronizationContext;
        private int _i = 100;
        private string _visibleImagePath = null;
        private readonly string[] _possibleAnswers = null;

        public CommonErrorsForm()
        {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;
            _files = Directory.GetFiles(Environment.CurrentDirectory +  @"..\..\..\ErrorPics");
            _possibleAnswers = new [] { "Missing File", "null instance", "divide by zero" };
            _possibleAnswers = _files.Select(f => Path.GetFileName(f)?.Replace(".png", "")).ToArray();
            lstAnswers.DataSource = _possibleAnswers;
            _answerQueue = new AnswerQueue<TrueFalseAnswer>(15);
            Next();
            lstAnswers.Click += LstAnswers_Click;
            StartTimer();
        }
        private async void StartTimer()
        {
            await Task.Run(() =>
            {
                for (_i = 100; _i > 0; _i--)
                {
                    UpdateProgress(_i);
                    Thread.Sleep(50);
                }
                Message("Need to be quicker on your feet next time!  Try again...");
            });
        }

        private void LstAnswers_Click(object sender, EventArgs e)
        {
            _i = 100;
            var selected = _possibleAnswers[lstAnswers.SelectedIndex];
            if (selected != null && selected == _visibleImagePath)
            {
                _answerQueue.Enqueue(new TrueFalseAnswer(true));
            }
            else
            {
                _answerQueue.Enqueue(new TrueFalseAnswer(false));
            }
            var tokens = _visibleImagePath.Split(' ');
            //TODO:  Figure out what is a valid answer.
            _answerQueue.Enqueue(new TrueFalseAnswer(true));
            Next();
        }

        private void Next()
        {
            if (_answerQueue.Count == 15 && _answerQueue.Grade >= 98)
            {
                MessageBox.Show("Congratulations you've defeated me!");
                Application.Exit();
                return;
            }
            label1.Text = _answerQueue.Grade.ToString() + "%";
            var file = _files.GetRandom();
            _visibleImagePath = Path.GetFileName(file)?.Replace(".png", "");
            _visibleImagePath= Path.GetFileName(file);
            pbImage.ImageLocation = file;
        }

        public void UpdateProgress(int value)
        {
            _synchronizationContext.Post(new SendOrPostCallback(x => {
                progress.Value = value;
            }), value);
        }
        public void Message(string value)
        {
            _synchronizationContext.Post(new SendOrPostCallback(x => {
                MessageBox.Show(value);
            }), value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
