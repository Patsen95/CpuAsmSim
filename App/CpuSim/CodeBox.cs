using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CpuSim
{
    public partial class CodeBox : UserControl
    {
        private PointF textPosition;
        private PointF caretPosition;

        private bool hasCaret = false;
        private bool gotFocus = false;


        private readonly int maxLength = 32767; // max # of characters in buffer
        //private int lineHeight;
        private int currentCharIndex;
        private StringBuilder sb;


        #region WinAPI

        [DllImport("user32.dll")]
        static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("User32.dll")]
        static extern bool SetCaretPos(int x, int y);

        [DllImport("User32.dll")]
        static extern bool DestroyCaret();

        [DllImport("User32.dll")]
        static extern bool ShowCaret(IntPtr hWnd);

        [DllImport("User32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        #endregion

        #region Properties
        [
            Category("Appearance"),
            Description("The text associated with the control."),
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public override string Text { get; set; }

        [
            Category("Appearance"),
            Description("If it's true, the caret is being displayed."),
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public bool DisplayCaret { get; set; }

        [
            Category("Behaviour"),
            Description("This property controls "),
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public bool TabAsSpaces { get; set; }

        [
            Category("Behaviour"),
            Description("This property controls "),
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public int TabSize { get; set; } = 4;
        #endregion

        public CodeBox()
        {
            InitializeComponent();
        }

        #region Behaviour methods
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = SystemColors.Window;
            this.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point);
            

            textPosition = new PointF(3f, 2f);
            sb = new StringBuilder(maxLength);
            DisplayCaret = true;
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e); // TODO
        }

        protected override bool ProcessTabKey(bool forward)
        {
            //return base.ProcessTabKey(forward);
            return this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using(Graphics g = e.Graphics)
            { 
                g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textPosition);
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            gotFocus = true;

            if(DisplayCaret)
            {
                if(!hasCaret)
                {
                    CreateCaret(this.Handle, IntPtr.Zero, 1, this.Font.Height);
                    hasCaret = true;
                }

                caretPosition = textPosition;
                SetCaretPos((int)textPosition.X + 2, (int)textPosition.Y);
                ShowCaret(this.Handle);
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            gotFocus = false;

            if(hasCaret)
            {
                DestroyCaret();
                hasCaret = false;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if(!gotFocus)
                return;

            e.SuppressKeyPress = false;

            int _inputChar = e.KeyValue;

            switch(e.KeyData)
            {
                // Backspace
                case Keys.Back:
                    if(sb.Length > 0)
                        sb.Remove(sb.Length - 1, 1);
                    break;

                // Enter
                case Keys.Enter:
                    sb.Append('\n');
                    break;

                // Space
                case Keys.Space:
                    sb.Append(" ");
                    break;

                // Shift
                case Keys.Shift:

                    break;

                // Tab
                //case Keys.Tab:
                //    //if(TabAsSpaces)
                //    //{
                //    //    for(int i = TabSize; i > 0; i--)
                //    //        sb.Append((char)32);
                //    //}
                //    //else
                //    //    sb.Append('\t');
                //    break;

                // Control
                case Keys.ControlKey:

                    break;

                // Alt
                case Keys.Alt:

                    break;

                // Arrow keys
                case Keys.Up:

                    break;

                case Keys.Down:

                    break;

                case Keys.Left:
                    if(currentCharIndex < 0)
                        currentCharIndex = 0;

                    if(currentCharIndex > sb.Length)
                        currentCharIndex = sb.Length;

                    currentCharIndex--;
                    break;

                case Keys.Right:
                    if(currentCharIndex < 0)
                        currentCharIndex = 0;

                    if(currentCharIndex > sb.Length)
                        currentCharIndex = sb.Length;

                    currentCharIndex++;
                    break;

                default:
                    // Checking if character is displayable
                    if(_inputChar > 32 && _inputChar < 127)
                    {
                        if(e.Modifiers == Keys.Shift)
                        {
                               
                        }
                        else if(_inputChar > 64 && _inputChar < 91)
                            _inputChar += 32;
                        sb.Append((char)_inputChar);
                    }
                    break;
            }
            this.Text = sb.ToString();
            this.Invalidate();
        }
        #endregion
    }
}
