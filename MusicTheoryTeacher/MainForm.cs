using System.Media;
using WMPLib;
namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //The labels REALLY wanted to fight being transparent
            #region Label Transparency Code

            lMode.Location = pbBlueScreen.PointToClient(lMode.Parent.PointToScreen(lMode.Location));
            lMode.Parent = pbBlueScreen;
            lMode.BackColor = Color.Transparent;
            lMode.ForeColor = Color.White;
            lMode.Text = "Scale";

            lNote.Location = pbBlueScreen.PointToClient(lNote.Parent.PointToScreen(lNote.Location));
            lNote.Parent = pbBlueScreen;
            lNote.BackColor = Color.Transparent;
            lNote.ForeColor = Color.White;
            lNote.Text = "C";

            lCategory.Location = pbBlueScreen.PointToClient(lCategory.Parent.PointToScreen(lCategory.Location));
            lCategory.Parent = pbBlueScreen;
            lCategory.BackColor = Color.Transparent;
            lCategory.ForeColor = Color.White;
            lCategory.Text = "Major";
            #endregion
        }

        #region Scale/Chord/Interval Array Collection

        string[] naturalNotes = { "", "C", "", "D", "", "E", "F", "", "G", "", "A", "", "B" }; //0 is blank so it can start on 1
        string[] sharpNotes = { }; //Future addition: Maybe just call natural notes and then set the start +1? and -1 for flats?
        string[] flatNotes = { };

        //Scales
        int[] majorScale = [2, 2, 1, 2, 2, 2, 1, 1];
        int[] pentatonicMajor = [2, 2, 3, 2, 3];        //Best for easy improv
        int[] naturalMinor = [2, 1, 2, 2, 1, 2, 2, 2];     //Theres 3 different minor scales but we'll deal with that later
        int[] bluesScale = [3, 2, 1, 1, 3, 2, 2];          //What I like to play
        int[] sharpsOnly = [2, 3, 2, 2, 3];             //Used for resetting colors, not really for music

        //Chords
        int[] majorChord = [4, 3, 0]; //0 at end so code loops enough times.
        int[] minorChord = [3, 4, 0];
        int[] diminishedChord = [3, 3, 0];
        int[] augmentedChord = [4, 4, 0];

        //Intervals
        int[] thirdInterval = [4, 0];
        int[] fifthInterval = [7, 0];   //A major 5th means its the 5th note in that scale. so in C major, G is the 5th, but its 7 keys higher. 
        int[] tritoneInterval = [6, 0];
        int[] seventhInterval = [10, 0];

        #endregion

        #region Initialize Forms and Fields
        //Forms
        ScalesForm scalesForm = new ScalesForm();
        ChordsForm chordsForm = new ChordsForm();
        IntervalForm intervalForm = new IntervalForm();
        private Form popupForm;

        //Fields
        const int pianoLength = 26;
        int startNote;
        int currentNote = 1;
        int[] pattern;
        List<Control> keys = new List<Control>();

        //Instruments
        string folder = "AccousticGrand";
        #endregion

        public void MainForm_Load(object sender, EventArgs e)
        {
            //Add default values on load
            startNote = 1;
            pattern = majorScale;
            popupForm = scalesForm;
            GetCategoryForm(popupForm);
            GetKeys();
            HighlightKeys();
        }

        #region Note Button Events

        //On click
        private void NoteClick(object sender, EventArgs e) //Click events pass relevant data for highlighting piano keys
        {
            GetNote(sender);
            GetKeys();
            HighlightKeys();
        }

        //On checked changed
        private void NoteCheckedChanged(object sender, EventArgs e) //Checked changed events handle UI button coloring
        {
            RadioButton note = (RadioButton)sender;
            if (!note.Checked) //If you are no longer checked, lose your color
            {
                note.FlatAppearance.BorderSize = 0;
                note.ForeColor = Color.White;
            }
            else //If you are now checked, get highlighted
            {
                note.FlatAppearance.BorderSize = 3;
                note.ForeColor = Color.FromArgb(82, 253, 252);
                lNote.Text = note.Text; //Update the label text
            }
        }
        #endregion

        #region Mode Button Events
        //On click
        private void ModeClick(object sender, EventArgs e)
        {
            UpdateModeAndCategory();
            GetCategoryForm(popupForm);
            GetCategoryText(); //Gotta update the category here too, since the category button events dont fire when swapping forms.
            GetKeys();
            HighlightKeys();
        }

        //On checked Changed
        public void ModeCheckedChanged(object sender, EventArgs e)
        {
            RadioButton mode = (RadioButton)sender;
            if (!mode.Checked)
            {
                //Uncolor the current button before coloring the new one
                mode.FlatAppearance.BorderSize = 0;
            }
            else
            {
                mode.FlatAppearance.BorderSize = 2;
                mode.FlatAppearance.CheckedBackColor = Color.White;
                lMode.Text = mode.Text;
            }
        }
        #endregion

        #region Category Button Events
        //On click
        public void CategoryClick(object sender)
        {
            UpdateModeAndCategory();
            GetKeys();
            HighlightKeys();
        }

        //On Checked Changed
        public void CategoryCheckedChanged(object sender)
        {
            RadioButton category = (RadioButton)sender;
            if (!category.Checked)
            {
                category.FlatAppearance.BorderSize = 0;
                category.ForeColor = Color.White;
            }
            else
            {
                category.FlatAppearance.BorderSize = 3;
                category.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
                category.ForeColor = Color.FromArgb(255, 128, 128);
                lCategory.Text = category.Text;
            }
        }
        #endregion

        #region Value Getting Methods

        //Method that determines the note clicked
        private void GetNote(object sender)
        {
            RadioButton clickedButton = (RadioButton)sender; //Im using radio buttons with their appearance set to that of a regular button.
            string startingNote = clickedButton.Text;
            //Future addition: If sharp.radio button is clicked: find index + 1
            startNote = Array.FindIndex(naturalNotes, x => x == startingNote); //Compares note to array of all notes and returns the index as the start note 
            currentNote = startNote;
        }

        private void UpdateModeAndCategory()
        {
            //The category is dependant on the mode, so mode must be determined first
            if (bScale.Checked)
            {
                popupForm = scalesForm;
                pattern = GetScale();
            }
            else if (bChord.Checked)
            {
                popupForm = chordsForm;
                pattern = GetChord();
            }
            else if (bInterval.Checked)
            {
                popupForm = intervalForm;
                pattern = GetInterval();
            }
        }

        private void GetCategoryText()
        {
            foreach (RadioButton categoryButton in popupForm.Controls)
            {
                if (categoryButton.Checked)
                {
                    lCategory.Text = categoryButton.Text;
                }
            }
        }

        //Method to swap forms
        private void GetCategoryForm(Form form)
        {
            popupForm?.Hide(); //If there already is a popup form, hide it.
            popupForm = form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.BackColor = panelCategory.BackColor;

            panelCategory.Controls.Clear();
            panelCategory.Controls.Add(form);

            form.Show();
        }

        private void GetKeys()
        {
            keys.Clear(); //Reset list

            startNote = currentNote; //Get the current note so that pattern updates consistently when switching modes and categories

            foreach (int interval in pattern) //Foreach number in the pattern array
            {
                Control[] pianoRoll = Controls.Find($"piano{startNote}", true); //Find the matching key
                foreach (Control c in pianoRoll)
                {
                    keys.Add(c); //Add it to the list
                }
                startNote += interval; //Next note in pattern
            }
        }

        #endregion

        #region Pattern Returning Conditionals
        //Flat conditionals are easier to follow compared to nested in my opinion
        private int[] GetInterval()
        {
            if (intervalForm.bThird.Checked)
            {
                return thirdInterval;
            }
            else if (intervalForm.bFifth.Checked)
            {
                return fifthInterval;
            }
            else if (intervalForm.bTritone.Checked)
            {
                return tritoneInterval;
            }
            else if (intervalForm.bSeventh.Checked)
            {
                return seventhInterval;
            }
            return thirdInterval; //Must add default value or it gets angry
        }

        private int[] GetChord()
        {
            if (chordsForm.bMajorChord.Checked)
            {
                return majorChord;
            }
            else if (chordsForm.bMinorChord.Checked)
            {
                return minorChord;
            }
            else if (chordsForm.bDiminishedChord.Checked)
            {
                return diminishedChord;
            }
            else if (chordsForm.bAugmentedChord.Checked)
            {
                return augmentedChord;
            }
            return majorChord; //Default
        }

        private int[] GetScale()
        {
            if (scalesForm.bMajorScale.Checked)
            {
                return majorScale;
            }
            else if (scalesForm.bMinorScale.Checked)
            {
                return naturalMinor;
            }
            else if (scalesForm.bBluesScale.Checked)
            {
                return bluesScale;
            }
            return majorScale; //Default
        }
        #endregion

        #region Key Coloring Methods
        //Method that highlights keys
        public void HighlightKeys()
        {
            ResetKeyColor(); //Reset key color or they all stay highlighted

            foreach (Control c in keys)
            {
                c.BackColor = Color.CornflowerBlue; //Highlight it
            }
        }

        //Method that resets the key colors
        private void ResetKeyColor()
        {
            int[] blackNotes = [2, 4, 7, 9, 11, 14, 16, 19, 21, 23]; //I was hoping for something more elegant but this is just the simplest way

            for (int notes = 1; notes < pianoLength; notes++) //Loop the length of piano
            {
                Control[] pianoRoll = Controls.Find($"piano{notes}", true);
                foreach (Control c in pianoRoll)
                {
                    //If the key is in the array, paint it black, if not: white
                    c.BackColor = blackNotes.Contains(notes) ? Color.FromArgb(33, 32, 37) : Color.FromArgb(213, 214, 216); //I used colors a little softer than black and white
                }
            }
        }
        #endregion

        #region Music Methods
        private void PianoKeyClick(object sender, EventArgs e)
        {
            WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer(); //Mediaplayer allows us to have more than one sound at a time
            mediaPlayer.settings.volume = 100;
            mediaPlayer.EndOfStream += MediaPlayer_EndOfStream; //Add event for when the sound ends

            string note = ((Button)sender).Tag.ToString(); //Using the tag property for the note association. The tag would be "C3 or F4" etc in this context

            //Switching instruments mid play doesnt seem to cause any errors, but keep an eye out.
            if (bGrand.Checked)
            {
                folder = "AccousticGrand";
            }
            else if (bElectric.Checked)
            {
                folder = "ElectricPiano2";
            }
            else if (bWurlitzer.Checked)
            {
                folder = "ElectricPiano1";
            }

            string filePath = @$"{folder}\{note}.mp3"; //I have a folder named this in the same directory as exe

            mediaPlayer.URL = filePath;
            mediaPlayer.controls.play();
        }

        private void InstrumentCheckedChanged(object sender, EventArgs e)
        {
            RadioButton instrument = (RadioButton)sender;
            if (!instrument.Checked)
            {
                //Uncolor the current button before coloring the new one
                instrument.FlatAppearance.BorderSize = 0;
            }
            else
            {
                instrument.FlatAppearance.BorderSize = 2;
                instrument.FlatAppearance.CheckedBackColor = Color.White;
            }
        }


        private void MediaPlayer_EndOfStream(int Result)
        {
            GC.Collect(); //Garbage collector
        }

        public async void PlayKeys(object sender, EventArgs e)
        {
            if (bScale.Checked)
            {
                Control[] scale = keys.ToArray(); //If list values change while loop is executing (such as when changing modes), the program crashes.
                foreach (Button k in scale)
                {
                    k.PerformClick();
                    await Task.Delay(250);
                }
            }
            else
            {
                foreach (Button k in keys)
                {
                    k.PerformClick();
                }
            }
        }

        #endregion

        private void bAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

    }
}