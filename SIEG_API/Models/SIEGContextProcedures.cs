﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SIEG_API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace SIEG_API.Models
{
    public partial class SIEGContext
    {
        private ISIEGContextProcedures _procedures;

        public virtual ISIEGContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new SIEGContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public ISIEGContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetSizeAndBidResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<GetSizeAndQuoteResult>().HasNoKey().ToView(null);
        }
    }

    public partial class SIEGContextProcedures : ISIEGContextProcedures
    {
        private readonly SIEGContext _context;

        public SIEGContextProcedures(SIEGContext context)
        {
            _context = context;
        }

        public virtual async Task<List<GetSizeAndBidResult>> GetSizeAndBidAsync(int? pCateID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "pCateID",
                    Value = pCateID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetSizeAndBidResult>("EXEC @returnValue = [dbo].[GetSizeAndBid] @pCateID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<GetSizeAndQuoteResult>> GetSizeAndQuoteAsync(int? pCateID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "pCateID",
                    Value = pCateID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetSizeAndQuoteResult>("EXEC @returnValue = [dbo].[GetSizeAndQuote] @pCateID", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
