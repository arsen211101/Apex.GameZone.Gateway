using Apex.GameZone.Core.Models;
using System.Collections.Generic;
using System;

namespace Apex.GameZone.API.ViewModels.Checkout;
public class CheckoutViewModel : CommonViewModel
{
    public int GameZoneId { get; set; }
    public int SectionId { get; set; }
    public DateTime Start { get; set; }
    public DateTime? ExpectedEnd { get; set; }
    public DateTime? End { get; set; }
    public int Bill { get; set; }

    public IEnumerable<ItemCheckoutViewModel> ConnectedItems { get; set; }
    public IEnumerable<ProductCheckoutViewModel> ConnectedProducts { get; set; }
}

