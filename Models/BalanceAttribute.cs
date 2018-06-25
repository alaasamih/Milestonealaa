using Sitecore.Diagnostics;
using Sitecore.Forms.Mvc;
using Sitecore.Forms.Mvc.Interfaces;
using Sitecore.Forms.Mvc.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace milestonealaa.Models
{
    /// <summary>
    /// The balance validator.
    /// </summary>
    public class BalanceAttribute : DynamicValidationBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceAttribute"/> class.
        /// </summary>
        /// <param name="balanceProperty">
        /// The balance property.
        /// </param>
        public BalanceAttribute(string balanceProperty)
        {
            Assert.ArgumentNotNullOrEmpty(balanceProperty, "balanceProperty");
            this.BalanceProperty = balanceProperty;
        }
        /// <summary>
        /// Gets or sets the balance property.
        /// </summary>
        public string BalanceProperty { get; set; }
        /// <summary>
        /// The get client validation rules.
        /// </summary>
        /// <param name="metadata">
        /// The metadata.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield break;
        }
        /// <summary>
        /// The is valid.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="validationContext">
        /// The validation context.
        /// </param>
        /// <returns>
        /// The <see cref="ValidationResult"/>.
        /// </returns>
        public override bool IsValid(object value)
        {
            return true;

        }

        protected override ValidationResult ValidateFieldValue(IViewModel model, object value, ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
        //public class BalanceAttribute : Sitecore.Forms.Mvc.Validators.DynamicValidationBase
        //{
        //    public BalanceAttribute(string balanceProperty)
        //    {
        //        Assert.ArgumentNotNullOrEmpty(balanceProperty, "balanceProperty");
        //        this.BalanceProperty = balanceProperty;
        //    }

        //    public string BalanceProperty { get; set; }
        //    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        //    {
        //        yield break;

        //    }
        //    protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        //    {
        //        var fieldModel = this.GetModel(validationContext);
        //        var balance = fieldModel.GetPropertyValue<decimal>(this.BalanceProperty);
        //        var valueString = value as string;
        //        if (string.IsNullOrEmpty(valueString))
        //        {
        //            return ValidationResult.Success;
        //        }
        //        decimal valueDecimal;
        //        decimal.TryParse(valueString, out valueDecimal);
        //        if (decimal.TryParse(valueString, out valueDecimal) && decimal.Parse(valueString) <= balance)
        //        {
        //            return ValidationResult.Success;
        //        }
        //        return new ValidationResult(string.Format(CultureInfo.CurrentCulture, this.GetErrorMessageTemplate(fieldModel), fieldModel.Title));
        //    }
        //}

    }
    }