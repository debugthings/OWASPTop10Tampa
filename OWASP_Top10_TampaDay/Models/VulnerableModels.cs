using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace OWASP_Top10_TampaDay.Models
{

    public class Comments
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "User")]
        public virtual ApplicationUser ApplicationUserId { get; set; }
        [AllowHtml]
        public string Comment { get; set; }
        [Display(Name = "Date Entered")]
        public DateTime CommentDate { get; set; }
    }

    public class Items
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Item Title")]
        public string Title { get; set; }
        [Display(Name = "Item Abstract")]
        [MaxLength(1024)]
        public string Abstract { get; set; }
        [Display(Name = "Item Detail")]
        [MaxLength(8000)]
        public string Detail { get; set; }

    }

    public class CommentsModelBinder : IModelBinder
    {

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {


            var comment = new Comments()
            {

                // Check to see if we've turned validation off
                Comment = controllerContext.Controller.ValidateRequest ? GetSanitizedValue(controllerContext, "Comment") : GetContextValue(bindingContext, "Comment")
            };
            return comment;

        }

#warning This code is potentially unsafe. It does not provide any kind of XSS protection or injection protection.
        /// <summary>
        /// This code is intentionally unsafe to illustrate the point of bad coding practices.
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private string GetUnvalidatedValue(ControllerContext controllerContext, string key)
        {

            var result = controllerContext.HttpContext.Request.Unvalidated.Form[key];
            var result2 = controllerContext.HttpContext.Request.Unvalidated.Form[key];
            return (result == null) ? null : result;

        }

        private string GetContextValue(ModelBindingContext bindingContext, string key)
        {
            var result = bindingContext.ValueProvider.GetValue(key);
            //var result2 = controllerContext.HttpContext.Request.Unvalidated.Form[key];
            return (result == null) ? null : result.AttemptedValue;

        }

        private string GetSanitizedValue(ControllerContext controllerContext, string key)
        {
            var result = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(controllerContext.HttpContext.Request.Unvalidated.Form[key]);
            return (result == null) ? null : result;
        }
    }
}