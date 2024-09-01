using System.Threading;
using System.Windows.Forms;

namespace SEMAPHORE___HW3___SP
{
    public partial class Form1 : Form
    {
        private int threadCount = 0;
        private SemaphoreSlim semaphoreSlim;

        public Form1()
        {
            InitializeComponent();
            semaphoreSlim = new SemaphoreSlim((int)numericUpDown_PlacesinSemaphore.Value);
        }

        private void button_CreateNew_Click(object sender, EventArgs e)
        {
            threadCount++;
            string threadName = $"Thread {threadCount}";
            listBox_CreatedThreads.Items.Add(threadName);
        }

        private void listBox_CreatedThreads_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_CreatedThreads.SelectedItem != null)
            {
                string selectedThread = listBox_CreatedThreads.SelectedItem.ToString();
                listBox_CreatedThreads.Items.Remove(selectedThread);
                listBox_WaitingThreads.Items.Add(selectedThread);
                MoveToWorking();
            }
        }

        private void listBox_WorkingThreads_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_WorkingThreads.SelectedItem != null)
            {
                listBox_WorkingThreads.Items.Remove(listBox_WorkingThreads.SelectedItem);
                semaphoreSlim.Release();
                MoveToWorking();
            }
        }

        private void MoveToWorking()
        {
            if (listBox_WaitingThreads.Items.Count > 0 && listBox_WorkingThreads.Items.Count < numericUpDown_PlacesinSemaphore.Value)
            {
                semaphoreSlim.Wait();
                string waitingThread = listBox_WaitingThreads.Items[0].ToString();
                listBox_WaitingThreads.Items.RemoveAt(0);
                listBox_WorkingThreads.Items.Add($"{waitingThread} -> {listBox_WorkingThreads.Items.Count + 1}");

                // новый поток для выполнения работы
                Thread newThread = new Thread(() => ThreadWork(waitingThread));
                newThread.Start();
            }
        }

        private void ThreadWork(string threadName)
        {
            Thread.Sleep(3000); 

            // Завершение работы потока
            Invoke(new Action(() =>
            {
                listBox_WorkingThreads.Items.Remove($"{threadName} -> {listBox_WorkingThreads.Items.Count}");
                semaphoreSlim.Release();
                MoveToWorking();
            }));
        }

        private void numericUpDown_PlacesinSemaphore_ValueChanged(object sender, EventArgs e)
        {
            int newValue = (int)numericUpDown_PlacesinSemaphore.Value;

            // Проверяем, чтобы значение было больше нуля
            if (newValue > 0)
            {
                //нужно увеличить количество доступных мест в семафоре
                int difference = newValue - semaphoreSlim.CurrentCount;

                if (difference > 0)
                {
                    semaphoreSlim.Release(difference);
                }
            }
            else
            {
                // Если значение равно нулю или меньше, устанавливаем минимальное значение на 1
                MessageBox.Show("Количество мест в семафоре должно быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDown_PlacesinSemaphore.Value = 1;
            }
        }
    }




}
