using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public static class ValidationHelper
    {
        public static bool IsStringsValid(params string[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    if (string.IsNullOrEmpty(item))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsDecimalsValid(params decimal?[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    if (!item.HasValue)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsDatetimesValid(params DateTime?[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    if (!item.HasValue)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsBooleanValid(params bool?[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    if (!item.HasValue)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsGuidValid(params Guid?[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    if (!item.HasValue)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsLongValid(params long?[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    if (!item.HasValue)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public static bool IsByteValid(params byte?[] parameters)
        {
            if (parameters != null && parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    if (!item.HasValue)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
