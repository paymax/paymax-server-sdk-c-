using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paymax.Config
{
    public class SignConfig
    {
        /// <summary>
        /// 商户自己的私钥【用com.Paymax.sign.RSAKeyGenerateUtil生成RSA秘钥对，公钥通过Paymax网站上传到Paymax，私钥设置到下面的变量中】
        /// </summary>
        public static readonly string PRIVATE_KEY = "<RSAKeyValue><Modulus>hd7A3hlwxuuuk9xM0kxWIBrCV838PdEZscdTUYr3F4mAGYmDvF8RQ43DPgtQZRPKhwDZ9VQCoDdIuydu7mlYwG2lm9mwrqAk95zTOBu7sMmrwdpwK/SElzs3348MD6qHWCyJSIKisoJ4R4bSqnucPWDma8D9kH/9YSDIIQrhZm0=</Modulus><Exponent>AQAB</Exponent><P>531drYdtmBIv1a7ToC7ACPp8RDMm/Gh462ituIM+vEKmxis/7HCCeSJ3JrcpknkUcbYrClcNXfaeSneSkrdO/w==</P><Q>lAtdQF90zL+PIaCFy4NGAaI5u6idfHzWsukDEgiqImIwC4Qgox8wutNDbbzpmRWaSqDyIze7rSqxKU/SMEr2kw==</Q><DP>A4klqiXcZas5cdEWyGaOZlS1GzGQ0eAioK3boWrXxXZbJ8G3WzwosgL1wPChQOx6hHYc2C6WNK40oryKz5TfLw==</DP><DQ>GWP5kljMx3DzM2k8iTLyhsUz8aNxnzAqAnVEOYuS4mLEqrT2hAONb/1byy5jQgYaeEIyRSgB4Ck6SUOPYQj6UQ==</DQ><InverseQ>pNXQ1jCDRXiXNgET3635RTnbFvXRZ2u98h8BELCozTsaZmGsZLWcQ5ITrstSYpcwqQMFhN7/4zjctaH2gl/Nmg==</InverseQ><D>KyY1fGEu3K8ywi4MBOzeBdMaOTsHxtUTNx5MWMg2BLwpMhIFCD6MTf3vpJv4+dt7ODCqEE1X21R2ePyo4OfL1yAq9sSJcu7cUDHpY2nSc9rJesSleQV7vZVxDDoCJH8rLw6dlgnfYbNomQ22N4dyFzwrhOQ4nMmp9XiR+B4iaXE=</D></RSAKeyValue>";
        /// <summary
        /// Paymax提供给商户的SecretKey，登录网站后查看
        /// </summary>
        public static readonly string SECRET_KEY = "55970fdbbf10459f966a8e276afa86fa";

        /// <summary>
        /// Paymax提供给商户的公钥，登录网站后查看
        /// </summary>
        public static readonly string PAYMAX_PUBLIC_KEY = "<RSAKeyValue><Modulus>1oaGYeqljG8JNLmHR0Hwi6xjQ1Hp8QcG6mLStz4cU3CD4dXmOXjXSvKVz1bQasIPtWx4l4XNKKNiriEA49givi3au0yGvYBBcb7KLaowWlAncI40pS7SE/HEI1hpsSMQhPV9xBuV86aHYoJGoR2Rt2utVy4qQQFb8lmK45S1dos=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";// "<RSAKeyValue><Modulus>nbuAWsRhqp2t6fXchkp/tsIQm9AiMk2d4DqQUAp3o7kCPMfZHsZRcBBpfIYJ6/ORifQ6Ocxn2Qyl8ZXdcDW7owLje8bgnXptHKDxmF/U6FlUIpS/SwMzNtICrrZnQuAiAfCiQxUcsSZewczsxPFjZUF2yG/JB92wKadLjz6pp5E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

    }
}
