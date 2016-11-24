using System;
using System.Text;
using System.Collections.Generic;


namespace NHibernate01.Domain {
    
    public class CurrencyRate {
        public CurrencyRate() { }
        public virtual int CurrencyRateId { get; set; }
        public virtual Currency FkCurrencyRateCurrencyFromCurrencyCode { get; set; }
        public virtual Currency FkCurrencyRateCurrencyToCurrencyCode { get; set; }
        public virtual DateTime CurrencyRateDate { get; set; }
        public virtual decimal AverageRate { get; set; }
        public virtual decimal EndOfDayRate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
