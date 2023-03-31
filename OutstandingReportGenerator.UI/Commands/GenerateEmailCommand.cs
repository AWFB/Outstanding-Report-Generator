
using OutstandingReportGenerator.UI.Stores;
using OutstandingReportGenerator.UI.ViewModels;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace OutstandingReportGenerator.UI.Commands
{
    public class GenerateEmailCommand : CommandBase
    {
        private OutstandingTestsTableVM _outstandingTestsTableVM;
        private readonly SelectedLabStore _selectedLabStore;

        public GenerateEmailCommand(OutstandingTestsTableVM outstandingTestsTableVM, SelectedLabStore selectedLabStore)
        {
            _outstandingTestsTableVM = outstandingTestsTableVM;
            _selectedLabStore = selectedLabStore;
            selectedLabStore.SelectedLabNameChanged += SelectedLabStore_SelectedLabNameChanged;
        }

        private void SelectedLabStore_SelectedLabNameChanged()
        {
            OnCanExecutedChanged();
        }


        public override bool CanExecute(object? parameter)
        {
            return _selectedLabStore.SelectedLab != null;
        }

        public override void Execute(object? parameter)
        {
            // get outstanding by lab name from view model
            StringBuilder html = GenerateEmail();

            string subject = "Outstanding Reports";

            CreateOutlookSession(html, subject);

        }

        private StringBuilder GenerateEmail()
        {
            var outstandingData = _outstandingTestsTableVM.Outstanding;

            StringBuilder html = new StringBuilder();

            html.Append("<p>Hello,</p>");
            html.Append("<p>Our records indicate that the following tests are outstanding on our system:</p>");

            html.Append("<table style='border-collapse: collapse;'>");
            html.Append("<thead>");
            html.Append("<tr>");
            html.Append("<th style='border: 1px solid black; padding: 8px; text-align: center;'>Name</th>");
            html.Append("<th style='border: 1px solid black; padding: 8px; text-align: center;'>Date of Birth</th>");
            html.Append("<th style='border: 1px solid black; padding: 8px; text-align: center;'>NHS Number</th>");
            html.Append("<th style='border: 1px solid black; padding: 8px; text-align: center;'>Test Name</th>");
            html.Append("<th style='border: 1px solid black; padding: 8px; text-align: center;'>Date Collected</th>");
            html.Append("</tr>");
            html.Append("</thead>");
            html.Append("<tbody>");


            foreach (var item in outstandingData)
            {
                var name = item.PatientName;
                var dateOfBirth = item.DateOfBirth;
                var nhsNumber = item.NHSNumber;
                var testName = item.TestName;
                var collectedDate = item.Collected;

                html.Append("<tr>");
                html.Append($"<td style='border: 1px solid black; padding: 8px; text-align: center;'>{name}</td>");
                html.Append($"<td style='border: 1px solid black; padding: 8px; text-align: center;'>{dateOfBirth}</td>");
                html.Append($"<td style='border: 1px solid black; padding: 8px; text-align: center;'>{nhsNumber}</td>");
                html.Append($"<td style='border: 1px solid black; padding: 8px; text-align: center;'>{testName}</td>");
                html.Append($"<td style='border: 1px solid black; padding: 8px; text-align: center;'>{collectedDate}</td>");
                html.Append("</tr>");
            }

            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");
            return html;
        }

        private static void CreateOutlookSession(StringBuilder html, string subject)
        {
            // Create an instance of Outlook application
            var outlookApp = new Outlook.Application();

            // Create a new MailItem object
            var mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML;
            // Set the subject and body of the email
            mailItem.Subject = subject;

            mailItem.HTMLBody = html.ToString();

            // Display the email
            mailItem.Display(false);
        }
    }
}
