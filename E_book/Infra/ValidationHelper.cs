using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_book.Infra
{
    public class ValidationHelper
    {
        public static bool Validate<T>(T model,
                           Dictionary<string, Control> map,
                           ErrorProvider errorProvider)
        {
            ValidationContext context = new ValidationContext(model, null, null);
            List<ValidationResult> errors = new List<ValidationResult>();

            errorProvider.Clear();
            bool validateAllProperties = true;
            bool isVaild = Validator.TryValidateObject(model, context, errors, validateAllProperties);
            if (!isVaild)
            {
                DisplayErrorsByErrorProvider(errors, map, errorProvider);
            }
            return isVaild;
        }
        private static void DisplayErrorsByErrorProvider(List<ValidationResult> erroes,
                                                              Dictionary<string, Control> map,
                                                              ErrorProvider errorProvider)
        {

            //this.errorProvider1.Clear();
            foreach (ValidationResult error in erroes)
            {
                string propName = error.MemberNames.FirstOrDefault();
                if (map.TryGetValue(propName, out Control ctrl))
                {
                    errorProvider.SetError(ctrl, error.ErrorMessage);
                }
            }



        }
    }
}
