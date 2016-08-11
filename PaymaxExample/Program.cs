using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paymax;
using Paymax.Utility;
using System.Diagnostics;

namespace PaymaxExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymaxClient payClient = new PaymaxClient();
            string CHARGE_CHANNEL = "alipay_app";
            string app_id = "app_9xSiRT643455T0L8";
            Dictionary<string, object> paramDic = CreateChargeParmeters(CHARGE_CHANNEL,app_id);

            try
            {
                //下单
                Console.WriteLine("开始下单：");
                CreateCharge(payClient, paramDic);

                Console.WriteLine("开始查询订单：");
                ////查询订单
                RetriveCharge(payClient);

                Console.WriteLine("开始创建退款订单：");
                //创建退款订单
                CreateRefundCharge(payClient);

                Console.WriteLine("开始查询退款订单");
                //查询退款订单
                RetriveRefundCharge(payClient);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error:" + ex.Message);
            }

            System.Console.ReadLine();
        }

        /// <summary>
        /// 创建退款订单
        /// </summary>
        /// <param name="payClient"></param>
        private static void CreateRefundCharge(PaymaxClient payClient)
        {
            Dictionary<string, object> dic = CreateRefundParmeters();
            String charge = "ch_e4cbdb4c9aa9cca77ae49b06";
            RefundModel refundModel = payClient.Refund(charge, dic);
            if (refundModel != null)
            {
                Debug.WriteLine("查询订单:" + refundModel.id);
                Console.WriteLine(refundModel.id);
            }
            else
            {
                Console.WriteLine("查询订单失败");
            }
        }

        /// <summary>
        /// 创建支付订单
        /// </summary>
        /// <param name="payClient"></param>
        /// <param name="paramDic"></param>
        private static void CreateCharge(PaymaxClient payClient, Dictionary<string, object> paramDic)
        {
            ChargeModel result = payClient.Charge(paramDic);
            if (result != null)
            {
                Console.WriteLine("下单成功");
                Debug.WriteLine(result);
                //输出订单信息
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("下单失败");
            }
        }

       /// <summary>
       /// 查询支付订单
       /// </summary>
       /// <param name="payClient"></param>
        private static void RetriveCharge(PaymaxClient payClient)
        {
            String chargeId = "ch_35004f998ce3de5bb4dacc9d";
            ChargeModel model = payClient.RetrieveCharge(chargeId);
            if (model != null)
            {
                Debug.WriteLine("查询订单:" + model.id);
                Console.WriteLine(model);
            }
            else
            {
                Console.WriteLine("查询订单失败");
            }
        }

        /// <summary>
        /// 查询退款订单
        /// </summary>
        /// <param name="payClient"></param>
        private static void RetriveRefundCharge(PaymaxClient payClient)
        {
            String ch_chargeId = "ch_e4cbdb4c9aa9cca77ae49b06";
            String re_chargeId = "re_50c188e484d82273e00a4bcf";
            RefundModel rm = payClient.RetrieveRefund(ch_chargeId, re_chargeId);
            if (rm != null)
            {
                Debug.WriteLine("查询退款订单:" + rm.id);
                Console.WriteLine(rm.id);
            }
            else
            {
                Console.WriteLine("查询退款订单失败");
            }
        }

        /// <summary>
        /// 创建支付订单的Dictionary参数
        /// </summary>
        /// <param name="CHARGE_CHANNEL">支付渠道编码</param>
        /// <param name="app_id">应用的ID</param>
        /// <returns></returns>
        private static Dictionary<string, object> CreateChargeParmeters(string CHARGE_CHANNEL,string app_id)
        {
            Dictionary<string, object> paramDic = new Dictionary<string, object>();

            paramDic.Add("amount", 0.1);
            paramDic.Add("subject", "my subject");
            paramDic.Add("body", "my body");
            paramDic.Add("order_no", Guid.NewGuid());
            paramDic.Add("channel", CHARGE_CHANNEL);
            paramDic.Add("client_ip", "127.0.0.1");
            paramDic.Add("app", app_id);
            paramDic.Add("currency", "CNY");
            paramDic.Add("description", "my description");
            paramDic.Add("user_id", "1511000000");

            Dictionary<string, object> extra = new Dictionary<string, object>();
            // extra.Add("user_id", "13601602858");
            extra.Add("open_id", "oH_qpuKEgf7PFhp9UKPv3Ywjz6aU");
            paramDic.Add("extra", extra);

            Dictionary<string, object> metadata = new Dictionary<string, object>();
            metadata.Add("metadata_key1", "metadata_value1");
            metadata.Add("metadata_key2", "metadata_value2");

            paramDic.Add("metadata", metadata);
            return paramDic;
        }

        /// <summary>
        /// 创建退款订单的参数
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, object> CreateRefundParmeters()
        {
            Dictionary<string, object> paramDic = new Dictionary<string, object>();
            paramDic.Add("amount", 0.1);
            paramDic.Add("description", "协商一致退款。");

            Dictionary<string, object> extra = new Dictionary<string, object>();
            extra.Add("user_id", "1511000000");
            paramDic.Add("extra", extra);

            Dictionary<string, object> metadata = new Dictionary<string, object>();
            metadata.Add("metadata_key1", "metadata_value1");
            metadata.Add("metadata_key2", "metadata_value2");

            paramDic.Add("metadata", metadata);
            return paramDic;
        }
    }
}
