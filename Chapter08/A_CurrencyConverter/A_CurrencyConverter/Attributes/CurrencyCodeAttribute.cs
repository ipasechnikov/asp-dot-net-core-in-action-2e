﻿using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace A_CurrencyConverter.Attributes
{
	public class CurrencyCodeAttribute : ValidationAttribute
	{
		private readonly string[] _allowedCodes;

		public CurrencyCodeAttribute(params string[] allowedCodes)
		{
			_allowedCodes = allowedCodes;
		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			string code = value as string;
			if (code == null || !_allowedCodes.Contains(code))
			{
				return new ValidationResult("Not a valid currency code");
			}

			return ValidationResult.Success;
		}
	}
}
