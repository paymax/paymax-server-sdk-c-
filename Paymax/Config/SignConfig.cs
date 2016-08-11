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
        public static readonly string PRIVATE_KEY = "<RSAKeyValue><Modulus>6ZJ3w0xXtGatQ27UaNIhGLpVFP8/TY6JnhFzd10RPnz/h5OGdqP6qQFDAYTVamdnZJFYUQOj7IboC2VCnow0/zDCe3Lg3qlyIEmyryAtJyNg4vbX6bYuVMdCaT/L7zCEI5KnhKcZucaJji5LUrqSN0hBsGLJoKZSeg7C9tanKus=</Modulus><Exponent>AQAB</Exponent><P>81IHiQ4I2S0BXrCkeRtPfRz9q7et/A+JtboGYFVW7e11s+xWbOWjML7FKh/JFUFzgLIXKdUx7Xn5o11rtkwIHw==</P><Q>9b5kp8784oIiHmWQzqYpALcPRT3jowpfhHHrnLFrM26s+U4NU+amjSZBLx6Ww9y7uQAuM7Xs/eMvJcEUEtDztQ==</Q><DP>NyUfKhOxM688gT5deEkVQdDBORq+5sKKvlHzwf91XSUVKPrmN3Xv/0stGjfr9dJIoCE8mLGFyEF9r2Wr1Lv0lw==</DP><DQ>qkBJw+inUtYNhTmgZUrAxXoN3k7OUrpxCnVSYrCYMH3Q4LeujB4T7V4/csGiefeHJth1KeY0VoD6vRFTMuYIsQ==</DQ><InverseQ>uQvWvRLmj0EARXHVafLYUSvSKmgEnk3SGfAMbEUnmKqdglRs6wJ1jk/u/RKEe/NkzJWT8CtDtvgYLD672fGGCQ==</InverseQ><D>UZEfNroF1M+YiTh+f/6FpVOI29TJYAW7ZFJ2zsPW/kn7mHZ52huosPVqV3DycH6c2j9xppUNXU+9YCFkEucmqB6t/WsR2eMqGUtBB8H+1NYmaSVT5mxk6qwyIMLWBcbJswprwjX66/lwr6jEpVr7QMcI6ZhCvF40RkX6ScMWMx0=</D></RSAKeyValue>";


        /// <summary>
        /// 给Paymax网站使用
        /// </summary>
        public static readonly string PUBLIC_KEY = "<RSAKeyValue><Modulus>6ZJ3w0xXtGatQ27UaNIhGLpVFP8/TY6JnhFzd10RPnz/h5OGdqP6qQFDAYTVamdnZJFYUQOj7IboC2VCnow0/zDCe3Lg3qlyIEmyryAtJyNg4vbX6bYuVMdCaT/L7zCEI5KnhKcZucaJji5LUrqSN0hBsGLJoKZSeg7C9tanKus=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        /// <summary
        /// Paymax提供给商户的SecretKey，登录网站后查看
        /// </summary>
        public static readonly string SECRET_KEY = "b2a184fc0e7242e4b3271ba78ce12d20";

        /// <summary>
        /// Paymax提供给商户的公钥，登录网站后查看
        /// </summary>
        public static readonly string PAYMAX_PUBLIC_KEY = "<RSAKeyValue><Modulus>nbuAWsRhqp2t6fXchkp/tsIQm9AiMk2d4DqQUAp3o7kCPMfZHsZRcBBpfIYJ6/ORifQ6Ocxn2Qyl8ZXdcDW7owLje8bgnXptHKDxmF/U6FlUIpS/SwMzNtICrrZnQuAiAfCiQxUcsSZewczsxPFjZUF2yG/JB92wKadLjz6pp5E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

    }
}
