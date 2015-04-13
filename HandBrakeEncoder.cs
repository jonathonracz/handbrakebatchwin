using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace HandBrake_Encoder
{
    public partial class handBrakeBatchEncoder : Form
    {

        #region Fields and Properties

        private string handBrakeCLI;
        private string handBrakeCMD;
        
        delegate void RemoveListItemCallBack();
        ToolTip handBrakeCMDTextBoxToolTip = new ToolTip();
        ToolTip handBrakeCLILocationTextBoxToolTip = new ToolTip();
        ToolTip encodeButtonToolTip = new ToolTip();
        ToolTip fileRemoveButtonToolTip = new ToolTip();
        ToolTip folderSelectButtonToolTip = new ToolTip();
        ToolTip folderRecursiveCheckBoxToolTip = new ToolTip();
        ToolTip encodeLocationButtonToolTip = new ToolTip();
        ToolTip encodeLocationTextBoxToolTip = new ToolTip();
        #endregion

		public class PostEncodeEventArgs : EventArgs
		{
			public string destination { get; set; }
			public DateTime timeStamp { get; set; }

			public PostEncodeEventArgs( string destination, DateTime timeStamp )
			{
				this.destination = destination;
				this.timeStamp = timeStamp;
			}
		}
		public event EventHandler<PostEncodeEventArgs> handler;

        #region Methods
        public handBrakeBatchEncoder()
        {
            InitializeComponent();

            handBrakeCLI = Properties.Settings.Default.HandBrakeCLILocation;
            handBrakeCMD = Properties.Settings.Default.HandBrakeCMD;
            
            encodeFolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            encodeLocationTextBox.Text = Properties.Settings.Default.DefaultEncodeLocation;
            
            handBrakeCLIOpenFileDialog.InitialDirectory = Environment.SpecialFolder.ProgramFiles.ToString();
            handBrakeCLIOpenFileDialog.Filter = "HandBrakeCLI|Handbrakecli.exe";

            handBrakeCMDTextBox.Text = handBrakeCMD;

            handBrakeCLILocationTextBox.Text = handBrakeCLI;
                        
            handBrakeCMDTextBoxToolTip.SetToolTip(handBrakeCMDTextBox, "Paste in here the query from handbrake. Remove the -i and -o sections of the query.");
            handBrakeCLILocationTextBoxToolTip.SetToolTip(handBrakeCLILocationTextBox, "Location of the HandBrake CLI Executable.");
            encodeButtonToolTip.SetToolTip(encodeButton, "Start the encode process.");
            fileRemoveButtonToolTip.SetToolTip(fileRemoveButton, "Remove item from the list.");
            encodeLocationButtonToolTip.SetToolTip(encodeLocationButton, "Select the output folder.");
            encodeLocationTextBoxToolTip.SetToolTip(encodeLocationTextBox, "Add your default to the settings.settings file so you dont have to select every time.");
        }

        private void encodeFiles()
        {
            string handbrake;
                        
            if (folderFileListBox.Items.Count > 0)
            {
                string source = folderFileListBox.Items[0].ToString();
				string destination;
				DateTime timeStamp;

				if ( saveNextToOriginalsCheckBox.Checked )
				{
					destination = Path.GetDirectoryName( source ) + '/' + Path.GetFileName( source );
				}
				else
				{
					destination = encodeLocationTextBox.Text + '/' + Path.GetFileName( source );
				}

				if (preserveTimeStampCheckBox.Checked)
				{
					timeStamp = File.GetCreationTime(source);
				}
				else
				{
					timeStamp = DateTime.Now;
				}

				destination = Path.ChangeExtension( destination, ".mp4" );
				PostEncodeEventArgs args = new PostEncodeEventArgs( destination, timeStamp );
				EventHandler<PostEncodeEventArgs> PostEncodeEvent = handler;
				if ( PostEncodeEvent != null )
				{
					PostEncodeEvent( this, args );
				}

                if (this.folderFileListBox.InvokeRequired)
                {
                    RemoveListItemCallBack d = new RemoveListItemCallBack(RemoveListItem);
                    this.Invoke(d);
                }
                else
                {
                    RemoveListItem();
                }

                handbrake = " -i " + '\u0022' + source + '\u0022';
                handbrake += " -o " + '\u0022' + destination + '\u0022';
                handbrake += " " + handBrakeCMDTextBox.Text;                
                Console.WriteLine(handBrakeCLILocationTextBox.Text + " " + handbrake);

				while ( !File.Exists( handBrakeCLILocationTextBox.Text ) )
				{
					handBrakeCLIButton_Click( this, null );
				}

                Process myprocess = Process.Start(handBrakeCLILocationTextBox.Text, handbrake);
                myprocess.EnableRaisingEvents = true;
                myprocess.Exited += new EventHandler(myprocess_exited);
            }
            else
            {
                MessageBox.Show("Encoding finished!", "Done", MessageBoxButtons.OK);
            }
        }
        private void RemoveListItem()
        {
            folderFileListBox.Items.RemoveAt(0);
        }
        #endregion

        #region Events       
        private void encodeLocationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = encodeFolderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                encodeLocationTextBox.Text = encodeFolderBrowserDialog.SelectedPath;
            }
        }        

        private void handBrakeCLIButton_Click(object sender, EventArgs e)
        {
            DialogResult result = handBrakeCLIOpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                handBrakeCLILocationTextBox.Text = handBrakeCLIOpenFileDialog.FileName;
            }
        }        

        private void encodeButton_Click(object sender, EventArgs e)
        {
            encodeFiles();
        }

        private void myprocess_exited( object sender, PostEncodeEventArgs e )
        {
            encodeFiles();
        }

        private void fileRemoveButton_Click(object sender, EventArgs e)
        {
            if (this.folderFileListBox.Items.Count > 0)
            {
                int selected = folderFileListBox.SelectedIndex;
                if (selected != -1)
                {
                    this.folderFileListBox.Items.RemoveAt(this.folderFileListBox.SelectedIndex);
                    if (selected == 0)
                    {
                        folderFileListBox.SelectedIndex = 0;
                    }
                    else
                    {
                        folderFileListBox.SelectedIndex = --selected;
                    }
                }
                else
                {
                    folderFileListBox.SelectedIndex= 0;
                }
            }
        }

        private void fileUpButton_Click(object sender, EventArgs e)
        {
            if (this.folderFileListBox.SelectedIndex == -1 || this.folderFileListBox.SelectedIndex == 0)
                return;

            Object select, previous, temp;
            select = folderFileListBox.Items[folderFileListBox.SelectedIndex];
            previous = folderFileListBox.Items[folderFileListBox.SelectedIndex - 1];
            temp = select;
            select = previous;
            previous = temp;
            folderFileListBox.Items[folderFileListBox.SelectedIndex] = select;
            folderFileListBox.Items[folderFileListBox.SelectedIndex - 1] = previous;

            folderFileListBox.SelectedIndex--;	
        }

        private void fileDownButton_Click(object sender, EventArgs e)
        {
            if (this.folderFileListBox.SelectedIndex == -1 || this.folderFileListBox.SelectedIndex == folderFileListBox.Items.Count - 1)
                return;

            Object select, next, temp;
            select = folderFileListBox.Items[folderFileListBox.SelectedIndex];
            next = folderFileListBox.Items[folderFileListBox.SelectedIndex + 1];
            temp = select;
            select = next;
            next = temp;
            folderFileListBox.Items[folderFileListBox.SelectedIndex] = select;
            folderFileListBox.Items[folderFileListBox.SelectedIndex + 1] = next;

            folderFileListBox.SelectedIndex++;
        }
        #endregion

		private void folderFileListBox_DragEnter(object sender, DragEventArgs e)
		{
			if ( e.Data.GetDataPresent( DataFormats.FileDrop ) )
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void folderFileListBox_DragDrop(object sender, DragEventArgs e)
		{
			string[] fileList = (string[])e.Data.GetData( DataFormats.FileDrop );

			foreach ( string file in fileList )
			{
				if ( File.Exists( file ) && !folderFileListBox.Items.Contains( file ) )
				{
					folderFileListBox.Items.Add( file );
				}
			}
		}

		private void saveNextToOriginalsCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if ( saveNextToOriginalsCheckBox.Checked )
			{
				encodeLocationTextBox.Enabled = false;
				encodeLocationButton.Enabled = false;
			}
			else
			{
				encodeLocationTextBox.Enabled = true;
				encodeLocationButton.Enabled = true;
			}
		}
    }
}