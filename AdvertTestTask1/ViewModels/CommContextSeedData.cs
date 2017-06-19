//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AdvertTestTask1.ViewModels
//{
//    public class CommContextSeedData
//    {
//        public CommissionContext _context;
//        public CommContextSeedData(CommissionContext context)
//        {
//            _context = context;
//        }
//        public async Task SudeSeedData()
//        {
//            if (!_context.Commissions.Any())
//            {
//                var emergCommission = new Commission()
//                {
//                    User = "RedheadFly",
//                    Email = "lf.redhead@gmail.com",
//                    OrderText = "Here you should explaine the main idea of future commission. " +
//                    "Characters, situations, spetial preferences in style. Also here you can point out your favorite author.",
//                    CommissionPrice = 10,
//                    CommTime = false
//                };
//                _context.Commissions.Add(emergCommission);
//                await _context.SaveChangesAsync();

                
//            }
//        }
//    }
//}
