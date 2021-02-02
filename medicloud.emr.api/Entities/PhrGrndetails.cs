using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Data
{
    public partial class PhrGrndetails
    {
        public int? GrndetailsId { get; set; }
        public int? Grnid { get; set; }
        public short? ItemSrNo { get; set; }
        public byte? ItemBatchSrNo { get; set; }
        public int? ItemId { get; set; }
        public int? ItemUnitId { get; set; }
        public int? BatchId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? BoxTotalQty { get; set; }
        public decimal? BoxFreeQty { get; set; }
        public decimal? BoxUnitCost { get; set; }
        public decimal? BoxMrp { get; set; }
        public decimal? BoxSalePrice { get; set; }
        public decimal? ReceivedQty { get; set; }
        public decimal? FreeQty { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? UnitMrp { get; set; }
        public decimal? UnitSalePrice { get; set; }
        public decimal? UnitCostActual { get; set; }
        public decimal? ConversionFactor1 { get; set; }
        public decimal? ConversionFactor2 { get; set; }
        public decimal? NetEffectivePrice { get; set; }
        public decimal? Charge { get; set; }
        public bool? Active { get; set; }
        public int? EncodedBy { get; set; }
        public DateTime? EncodedDate { get; set; }
        public int? LastChangedBy { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public int? QuotationId { get; set; }
        public int? ConsignmentId { get; set; }
        public bool? Updated { get; set; }
        public decimal? MrpForVat { get; set; }
        public decimal? MarkupPerc { get; set; }
        public decimal? BoxMrpold24062016 { get; set; }
        public decimal? BoxSalePriceOld24062016 { get; set; }

    public static implicit operator PhrGrndetails(decimal? v)
    {
      throw new NotImplementedException();
    }
  }
}
