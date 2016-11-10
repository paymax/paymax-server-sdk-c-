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
        public static readonly string PRIVATE_KEY = "<RSAKeyValue><Modulus>40xLsyGM0ARR34mKgpZAvfvm1iwvcuWvAeVdaZB7gFH7ktOa+kfFdgSyKc2ROvl2V+brlBg9sOR/r/zR7QcSGQbWKvRGdb9w8nLp/fg3MtSDOqKZhGatw4WvVbHKvXHRvLI7jQMev8xeTt5r8OAT6y17eBNAH8HiPbwp+/lERyU=</Modulus><Exponent>AQAB</Exponent><P>/htWIuPLs5ReHt1ZCF7q08OMHucgDphvKmQoWb/IRm57wST3Qy/AUJdF3EFu7FcVWIeyutPTUDsNQ5Ykv/V6hw==</P><Q>5P3TiGhxe1QWDcNkaJflzh1fNEKGLDwJiq7Y/mUnOq5894qyLkqlTo0YmLelwPz5lIa7V7oswP1aya8VLsh/8w==</Q><DP>6IKc83nax2wIH1fMgsNPPgudKB22EITcmz5gSZcZq5CmvlmTwq9r2pJAg0SAOdOJHaO1IAx5O918yo4U/Gyi+w==</DP><DQ>ZZnRf1aH82ZtmpG1PUsYJYmWskNJ8Np6iVPm54jODRVaUSLyx+NK0T19SlVBcA1OV34oJVZvgPlojM/oICfJzQ==</DQ><InverseQ>0xsVbT8e0dDmxkWdxL/38MVTLR/RDgRhgPmijuHHm8Y0ox05O+AVGmljDrPRGwqIcOhSc5HErgkiX4SFIyRs6w==</InverseQ><D>TiZcXLGrXZYupEIBCpcomWmz222DvuhzvJ4k+PfBTsRhUAFLZsQog0RoEXFpfrJo2x49X0TaaSiXMmYls25b7PLPuFJkHfCrzWbTJsmZ/GlWXxh76RKAenWxWlscY+tf64WwcEUSEiM8qYlIAae9SbgpBWhp1fWC30Jryr+dn10=</D></RSAKeyValue>";

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
