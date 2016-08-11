using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paymax.Business;
using Paymax.Excep;

namespace Paymax
{
     /// <summary>
    /// Paymax支付PC端接口
    /// </summary>
    public class PaymaxClient
    {
        /// <summary>
        /// 支付
        /// </summary>
        /// <param name="argParams"></param>
        /// <returns></returns>
        public ChargeModel Charge(Dictionary<string, object> argParams)
        {
            try
            {
                ChargeBusiness bll = new ChargeBusiness();
                ChargeModel m = bll.Charge(argParams);
                Console.WriteLine("********************************************");
                Console.WriteLine(m);
                Console.WriteLine("********************************************");
                return m;
            }
            catch (AuthorizationException ex)
            {
                throw new Exception("认证错误:" + ex.Message);
            }
            catch (InvalidRequestException ex)
            {
                throw new Exception("无效请求:" + ex.Message);
            }
            catch (InvalidResponseException ex)
            {
                throw new Exception("无效返回:" + ex.Message);
            }

        }

        /// <summary>
        /// 查询支付
        /// </summary>
        /// <param name="argChargeId">支付编号</param>
        /// <returns></returns>
        public ChargeModel RetrieveCharge(string argChargeId)
        {
            try
            {
                ChargeBusiness bll = new ChargeBusiness();

                return bll.Retrieve(argChargeId);
            }
            catch (AuthorizationException ex)
            {
                throw new Exception("认证错误:" + ex.Message);
            }
            catch (InvalidRequestException ex)
            {
                throw new Exception("无效请求:" + ex.Message);
            }
            catch (InvalidResponseException ex)
            {
                throw new Exception("无效返回:" + ex.Message);
            }
        }

        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="argChargeId">支付编号</param>
        /// <param name="argParams"></param>
        /// <returns></returns>
        public RefundModel Refund(string argChargeId, Dictionary<string, object> argParams)
        {
            try
            {
                RefundBusiness bll = new RefundBusiness();

                return bll.Create(argChargeId, argParams);
            }
            catch (AuthorizationException ex)
            {
                throw new Exception("认证错误:" + ex.Message);
            }
            catch (InvalidRequestException ex)
            {
                throw new Exception("无效请求:" + ex.Message);
            }
            catch (InvalidResponseException ex)
            {
                throw new Exception("无效返回:" + ex.Message);
            }
        }

        /// <summary>
        /// 查询退款
        /// </summary>
        /// <param name="argChargeId">支付编号</param>
        /// <param name="argRefundId">退款编号</param>
        /// <returns></returns>
        public RefundModel RetrieveRefund(string argChargeId, string argRefundId)
        {
            try
            {
                RefundBusiness bll = new RefundBusiness();

                return bll.Retrieve(argChargeId, argRefundId);
            }
            catch (AuthorizationException ex)
            {
                throw new Exception("认证错误:" + ex.Message);
            }
            catch (InvalidRequestException ex)
            {
                throw new Exception("无效请求:" + ex.Message);
            }
            catch (InvalidResponseException ex)
            {
                throw new Exception("无效返回:" + ex.Message);
            }
        }

    }
}
