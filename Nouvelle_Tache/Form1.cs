namespace Nouvelle_Tache
{
    public partial class New_Tache : Form
    {

        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public New_Tache()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool NameIsGood = GoodName();
            bool DescriptionIsGood = GoodDescription();
            if (NameIsGood && DescriptionIsGood)
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }

        public bool GoodName()
        {
            try
            {
                if(TaskNameText.Text.Length == 0)
                {
                    TaskNameText.Text = "";
                    NameTaskError.Text = "Veuiller renseigner le champ";
                    return false;
                }
                else
                {
                    TaskName = TaskNameText.Text;
                    NameTaskError.Text = "";
                    return true;
                }
            }
            catch (Exception ex)
            {
                TaskNameText.Text = "";
                NameTaskError.Text = $"une erreur est survenue{ex}";
                return false;
            }
        }

        public bool GoodDescription()
        {
            try
            {
                if (TaskDescriptionText.Text.Length == 0)
                {

                    DescriptionTaskError.Text = "Veuiller renseigner le champ";
                    return false;
                }
                else
                {
                    TaskDescription = TaskDescriptionText.Text;                   
                    DescriptionTaskError.Text = "";
                    return true;
                }
            }
            catch ( Exception ex )
            {
                TaskDescriptionText.Text = $"une erreur est survenue{ex}";
                return false;
            }
        }

    }
}
