using System;
using System.Collections.Generic;
using System.Text;

namespace CCALib_Testing.Enums
{
    public enum ExitCode
    {
        Success = 0,
        InvalidNumberOfArguments = 11,
        JsonFileError = 21,
        UnableToConnectToSql = 31,
        TaskDefinitionNotFound = 32,
        StoredProcedureNotFound = 33,
        OneOrMoreButNotAllStoredProceduresMissing = 34,
        AllStoredProceduresMissing = 35,
        StoredProcedureInvalidParameters = 36,
        OneOrMoreButNotAllStoredProceduresInvalidParameters = 37,
        AllStoredProceduresInvalidParameters = 38,
        ErrorThrownByStoredProcedure = 51,
        UnknownError = 999
    }
}
