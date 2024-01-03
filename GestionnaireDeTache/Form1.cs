namespace GestionnaireDeTache
{

    using Nouvelle_Tache;
    using SaveData;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Windows.Forms;
    using static System.Net.WebRequestMethods;

    public partial class Form1 : Form
    {

        private List<string> originalItems = new List<string>();
        private JsonDatabase jsonDatabase = new JsonDatabase();

        public Form1()
        {
            //initalisation de l'application
            InitializeComponent();
            SearchTask.Click += SearchTask_Click;
            MessageBox.Show("La v1 du gestionnaire de tache ne permet pas d'avoir les croix cocher fonctionnel. Merci de votre comprhéension (Discord : kys3n) ", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            //Ajout des données enregistrer dans la database
            if (!jsonDatabase.LoadData(originalItems))
            {
                MessageBox.Show($"une est survenue pour le chargement des données ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TacheList.Items.AddRange(originalItems.ToArray());
        }




        private bool isAscending()
        {
            return SortedList.Text == "Nom ↑";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteTaskError.Text = "";
            New_Tache newtask = new New_Tache();
            newtask.ShowDialog();


            if (newtask.DialogResult == DialogResult.OK)
            {
                TacheList.Items.Add($"{newtask.TaskName} :   {newtask.TaskDescription}");
                originalItems.Add($"{newtask.TaskName} :   {newtask.TaskDescription}");



                if (isAscending())
                {
                    ReverseListBox();
                    TacheList.Sorted = false;
                }
                else if (!isAscending())
                {

                    TacheList.Sorted = true;
                    TacheList.Sorted = false;
                }
                //sauvegarde les données dans la database
                jsonDatabase.SaveData(originalItems);
            }

        }


        private void Supprimer_Tache_Click(object sender, EventArgs e)
        {
            if (TacheList.Items.Count == 0)
            {
                DeleteTaskError.Text = "La liste est vide";
            }
            else if (TacheList.SelectedIndex < 0)
            {

                DeleteTaskError.Text = "selectionner un element";

            }
            else
            {
                DeleteTaskError.Text = "";


                string selectedTask = TacheList.SelectedItem.ToString();

                originalItems.Remove(selectedTask);
                TacheList.Items.Remove(selectedTask);


                //sauvegarde les données dans la database
                jsonDatabase.SaveData(originalItems);

            }
        }

        private void Supprimer_Liste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("voulez vous vraiment supprimer toute les taches (veiller a ne rien avoir ecris dans la barre de recherche) ?", "confirmer l'action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            TacheList.Items.Clear();
            originalItems.Clear();

            //sauvegarde les données dans la database
            jsonDatabase.SaveData(originalItems);
        }




        private void SearchTask_TextChanged(object sender, EventArgs e)
        {
            if (SearchTask.Text.Length > 20)
            {
                SearchTask.Text = SearchTask.Text.Substring(0, 20);
                SearchTask.SelectionStart = SearchTask.Text.Length;
            }
            UpdateList();

        }

        private void UpdateList()
        {
            string searchText = SearchTask.Text.ToLower();

            TacheList.BeginUpdate();
            TacheList.Items.Clear();

            // Réafficher les éléments d'origine si le texte de recherche est vide
            if (string.IsNullOrEmpty(searchText))
            {
                TacheList.Items.AddRange(originalItems.ToArray());
            }
            else
            {
                // Filtrer les éléments en fonction du texte de recherche
                foreach (var item in originalItems)
                {
                    // Si le nom de l'élément (partie avant ":") contient le texte de recherche
                    if (item.ToLower().Split(':')[0].Contains(searchText))
                    {
                        TacheList.Items.Add(item);
                    }
                }
            }


            TacheList.EndUpdate();
        }



        private void SearchTask_Click(object sender, EventArgs e)
        {
            SearchTask.SelectAll();
            SearchTask.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (TacheList.Items.Count <= 0)
            {
                NameSortedList.Text = "Vous devez d'abord ajouter un élément";
            }
            else
            {
                TacheList.BeginUpdate();
                NameSortedList.Text = "";

                if (isAscending())
                {
                    SortedList.Text = "Nom ↓";
                    TacheList.Sorted = true;
                    TacheList.Sorted = false;
                }
                else
                {
                    SortedList.Text = "Nom ↑";
                    ReverseListBox();
                    TacheList.Sorted = false;
                }
                TacheList.EndUpdate();
            }
        }

        private void ReverseListBox()
        {
            TacheList.Sorted = true;

            for (int i = 0, j = TacheList.Items.Count - 1; i < j; i++, j--)
            {
                object temp = TacheList.Items[i];
                TacheList.Items[i] = TacheList.Items[j];
                TacheList.Items[j] = temp;
            }
        }




        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = "https://github.com/AlexisSerano";
            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
        }

        private void Discord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = "https://discord.gg/G9QscJaNPF";

            Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
        }
    }
}
