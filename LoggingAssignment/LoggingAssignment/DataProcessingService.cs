﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace LoggingAssignment
{
    public class DataProcessingService
    {
        private readonly ILogger<DataProcessingService> _logger;
        public DataProcessingService(ILogger<DataProcessingService> logger)
        {
            _logger = logger;
        }

        public void ProcessAndDisplay(string input)
        {
            _logger.LogInformation("Processing input: {Input}", input.ToUpper());
        }
    }
}
