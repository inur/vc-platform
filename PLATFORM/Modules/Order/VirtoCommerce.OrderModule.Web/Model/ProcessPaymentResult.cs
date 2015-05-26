﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VirtoCommerce.Domain.Payment.Model;

namespace VirtoCommerce.OrderModule.Web.Model
{
	public class ProcessPaymentResult
	{
		[JsonConverter(typeof(StringEnumConverter))]
		public PaymentStatus NewPaymentStatus { get; set; }

		public string RedirectUrl { get; set; }

		public bool IsSuccess { get; set; }

		public string Error { get; set; }

		public string OuterId { get; set; }
	}
}