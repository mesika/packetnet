﻿/*
This file is part of PacketDotNet

PacketDotNet is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PacketDotNet is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with PacketDotNet.  If not, see <http://www.gnu.org/licenses/>.
*/
/*
 *  Copyright 2017 Andrew <pandipd@outlook.com>
 */

namespace PacketDotNet
{
    /// <summary>
    /// Drda Code Point Type
    /// </summary>
    public enum DrdaCodePointType : ushort
    {
        Data = 0x0000,
        CodePoint = 0x000C,
        FdOcaDataDescriptor = 0x0010,
        DataTypeDefinitionName = 0x002F,
        TypDefOverrides = 0x0035,
        CodePointDataRepresentation = 0x0064,
        ExchangeServerAttributes = 0x1041,
        SyncPointControlRequest = 0x1055,
        SyncPointResyncCommand = 0x1069,
        AccessSecurity = 0x106D,
        SecurityCheck = 0x106E,
        SyncPointLog = 0x106F,
        ResourceTypeInformation = 0x111F,
        ReasonCodeInformation = 0x1127,
        ResourceNameInformation = 0x112D,
        ProductSpecificIdentifier = 0x112E,
        ConversationProtocolErrorCode = 0x113F,
        VersionName = 0x1144,
        ServerClassName = 0x1147,
        SeverityCode = 0x1149,
        SyntaxErrorCode = 0x114A,
        ServerDiagnosticInformation = 0x1153,
        ServerProductReleaseLevel = 0x115A,
        SupervisorName = 0x115D,
        ExternalName = 0x115E,
        ServerName = 0x116D,
        SecurityManagerName = 0x1196,
        ManagerDependencyErrorCode = 0x119B,
        CcsidForSingleByteCharacters = 0x119C,
        CcsidForDoubleByteCharacters = 0x119D,
        CcsidForMixedByteCharacters = 0x119E,
        UserIdAtTargetSystem = 0x11A0,
        Password = 0x11A1,
        SecurityMechanism = 0x11A2,
        SecurityCheckCode = 0x11A4,
        SecurityServiceErrorNumber = 0x11B4,
        SecurityToken = 0x11DC,
        NewPassword = 0x11DE,
        ManagerLevelConflict = 0x1210,
        ManagerDependencyError = 0x1218,
        SecurityCheckRdb = 0x1219,
        NotAuthorizedToCommand = 0x121C,
        PermanentAgentError = 0x1232,
        ResourceLimitsReached = 0x1233,
        ConversationalProtocolError = 0x1245,
        CommandProcessingCompleted = 0x124B,
        DataStreamSyntaxError = 0x124C,
        CommandNotSupported = 0x1250,
        ParameterNotSupported = 0x1251,
        ParameterValueNotSupported = 0x1252,
        ObjectNotSupported = 0x1253,
        CommandCheck = 0x1254,
        TargetNotSupported = 0x125F,
        Agent = 0x1403,
        ManagerLevelList = 0x1404,
        Supervisor = 0x143C,
        SecurityManager = 0x1440,
        ServerAttributesReplyData = 0x1443,
        Lu62ConversationalCommunicationsManager = 0x1444,
        Dictionary = 0x1458,
        ManagerLevelNumberAttribute = 0x1473,
        TcpIPCommunicationManager = 0x1474,
        FdoCaData = 0x147A,
        SnaLu62SyncPointConversationalCommunicationsManager = 0x147C,
        AccessSecurityReplyData = 0x14AC,
        SyncPointManager = 0x14C0,
        ResynchronizationManager = 0x14C1,
        CcsidManager = 0x14CC,
        MonitorEvents = 0x1900,
        MonitorReplyData = 0x1C00,
        XaManager = 0x1C01,
        AccessRdb = 0x2001,
        BeginBindingPackage = 0x2002,
        BindSqlStatement = 0x2004,
        CloseQuery = 0x2005,
        ContinueQuery = 0x2006,
        DropPackage = 0x2007,
        DescribeSqlStatement = 0x2008,
        EndBindingPackageToRdb = 0x2009,
        ExecuteImmediateSqlStatement = 0x200A,
        ExecuteSqlStatement = 0x200B,
        OpenQuery = 0x200C,
        PrepareSqlStatement = 0x200D,
        RdbCommitUnitOfWork = 0x200E,
        RdbRollbackUnitOfWork = 0x200F,
        RebindExistingPackage = 0x2010,
        DescribeRdbTable = 0x2012,
        SetSqlEnvironment = 0x2014,
        DescriptionErrorCode = 0x2101,
        QueryProtocolType = 0x2102,
        RdbInterruptToken = 0x2103,
        ProductSpecificData = 0x2104,
        RdbCommitAllowed = 0x2105,
        RdbCollectionIdentifier = 0x2108,
        PackageIdentifier = 0x2109,
        PackageConsistencyToken = 0x210D,
        ReturnSetStatement = 0x210E,
        RdbAccessManagerClass = 0x210F,
        RelationalDatabaseName = 0x2110,
        OutputExpected = 0x2111,
        PackageNameAndConsistencyToken = 0x2112,
        PackageNameConsistencyTokenAndSectionNumber = 0x2113,
        QueryBlockSize = 0x2114,
        UnitOfWorkDisposition = 0x2115,
        ReturnSqlData = 0x2116,
        RdbAllowUpdates = 0x211A,
        HoldCursorPosition = 0x211F,
        StatementStringDelimiter = 0x2120,
        StatementDecimalDelimiter = 0x2121,
        PackageDefaultCharacterSubType = 0x2125,
        QueryBlockProtocolControl = 0x2132,
        CorrelationToken = 0x2135,
        ProcedureName = 0x2138,
        PackageNameList = 0x2139,
        NumberOfFetchOrInsertRows = 0x213A,
        TargetDefaultValueReturn = 0x213B,
        QueryRelativeScrollingAction = 0x213C,
        QueryRowNumber = 0x213D,
        QueryRefreshAnswerSetTable = 0x213E,
        MaximumResultSetCount = 0x2140,
        MaximumNumberOfExtraBlocks = 0x2141,
        ResultSetFlags = 0x2142,
        TypeOfSqlDescriptorArea = 0x2146,
        OutputOverrideOption = 0x2147,
        ReturnExternalDataOption = 0x2148,
        QueryAttributeScrollability = 0x2149,
        QueryAttributeUpdatability = 0x2150,
        QueryScrollOrientation = 0x2152,
        QueryRowSensitivity = 0x2153,
        QueryBlockReset = 0x2154,
        QueryReturnsData = 0x2155,
        QueryRowsetSize = 0x2156,
        QueryAttributeSensitivity = 0x2157,
        QueryInstanceIdentifier = 0x215B,
        QueryCloseImplicit = 0x215D,
        QueryCloseLockRelease = 0x215E,
        QueryOptionalValue = 0x215F,
        SqlErrorDiagnosticLevel = 0x2160,
        AccessToRdbCompleted = 0x2201,
        QueryNotOpen = 0x2202,
        RdbNotAccessed = 0x2204,
        OpenQueryComplete = 0x2205,
        PackageBindingNotActive = 0x2206,
        RdbCurrentlyAccessed = 0x2207,
        BeginBindError = 0x2208,
        PackageBindingProcessActive = 0x2209,
        InvalidDescription = 0x220A,
        EndOfQuery = 0x220B,
        EndUnitOfWorkCondition = 0x220C,
        AbnormalEndUnitPfWorkCondition = 0x220D,
        DataDescriptorMismatch = 0x220E,
        QueryPreviouslyOpened = 0x220F,
        RdbNotFound = 0x2211,
        OpenQueryFailure = 0x2212,
        SqlErrorCondition = 0x2213,
        RdbUpdateReplyMessage = 0x2218,
        ResultSetReplyMessage = 0x2219,
        RdbRdbAccessFailedReplyMessage = 0x221A,
        CommandViolation = 0x221D,
        CommitmentRequest = 0x2225,
        NotAuthorizedToRdb = 0x22CB,
        SqlApplicationManager = 0x2407,
        SqlCommunicationsAreaReplyData = 0x2408,
        SqlResultSetColumnInformationReplyData = 0x240B,
        SqlResultSetReplyData = 0x240E,
        RelationalDatabase = 0x240F,
        ForceFixedRowQueryProtocol = 0x2410,
        SqlDaReplyData = 0x2411,
        SqlProgramVariableData = 0x2412,
        SqlDataReplyData = 0x2413,
        SqlStatement = 0x2414,
        OutputOverrideDescriptor = 0x2415,
        LimitedBlockProtocol = 0x2417,
        FixedRowQueryProtocol = 0x2418,
        SqlStatementVariableDescriptions = 0x2419,
        QueryAnswerSetDescription = 0x241A,
        QueryAnswerSetData = 0x241B,
        SqlStatementAttributes = 0x2450
    }
}