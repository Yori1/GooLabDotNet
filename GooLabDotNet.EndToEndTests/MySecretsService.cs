using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;

namespace GooLabDotNet.EndToEndTests
{
    public class MySecretsService
    {
        private readonly MySecrets mySecrets;

        public MySecretsService(IOptions<MySecrets> options)
        {
            mySecrets = options.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public MySecrets getSecrets()
        {
            return mySecrets;
        }

    }
}
