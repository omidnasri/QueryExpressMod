using ScintillaNET;
using System.Drawing;

namespace QueryExpress
{
    public class FastColoredTextBoxWithModificationTracking : Scintilla
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();


            Dock = System.Windows.Forms.DockStyle.Fill;
            WrapMode = WrapMode.None;
            IndentationGuides = IndentView.LookBoth;
            InitSqlStyle();
        }

        private void InitSqlStyle()
        {
            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            StyleResetDefault();
            Styles[Style.Default].Font = "Consolas";
            Styles[Style.Default].Size = 12;
            StyleClearAll();

            // Configure the CPP (C#) lexer styles
            Styles[Style.Cpp.Default].ForeColor = Color.Silver;
            Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0); // Green
            Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128); // Gray
            Styles[Style.Cpp.Number].ForeColor = Color.Olive;
            Styles[Style.Cpp.Word].ForeColor = Color.Blue;
            Styles[Style.Cpp.Word2].ForeColor = Color.Blue;
            Styles[Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21); // Red
            Styles[Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21); // Red
            Styles[Style.Cpp.StringEol].BackColor = Color.Pink;
            Styles[Style.Cpp.Operator].ForeColor = Color.Purple;
            Styles[Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            Lexer = Lexer.Sql;

            // Set the keywords
            SetKeywords(0, "ADD EXTERNAL PROCEDURE ALL FETCH PUBLIC ALTER FILE RAISERROR AND FILLFACTOR READ ANY FOR READTEXT AS FOREIGN RECONFIGURE ASC FREETEXT REFERENCES AUTHORIZATION FREETEXTTABLE REPLICATION BACKUP FROM RESTORE BEGIN FULL RESTRICT BETWEEN FUNCTION RETURN BREAK GOTO REVERT BROWSE GRANT REVOKE BULK GROUP RIGHT BY HAVING ROLLBACK CASCADE HOLDLOCK ROWCOUNT CASE IDENTITY ROWGUIDCOL CHECK IDENTITY_INSERT RULE CHECKPOINT IDENTITYCOL SAVE CLOSE IF SCHEMA CLUSTERED IN SECURITYAUDIT COALESCE INDEX SELECT COLLATE INNER SEMANTICKEYPHRASETABLE COLUMN INSERT SEMANTICSIMILARITYDETAILSTABLE COMMIT INTERSECT SEMANTICSIMILARITYTABLE COMPUTE INTO SESSION_USER CONSTRAINT IS SET CONTAINS JOIN SETUSER CONTAINSTABLE KEY SHUTDOWN CONTINUE KILL SOME CONVERT LEFT STATISTICS CREATE LIKE SYSTEM_USER CROSS LINENO TABLE CURRENT LOAD TABLESAMPLE CURRENT_DATE MERGE TEXTSIZE CURRENT_TIME NATIONAL THEN CURRENT_TIMESTAMP NOCHECK TO CURRENT_USER NONCLUSTERED TOP CURSOR NOT TRAN DATABASE NULL TRANSACTION DBCC NULLIF TRIGGER DEALLOCATE OF TRUNCATE DECLARE OFF TRY_CONVERT DEFAULT OFFSETS TSEQUAL DELETE ON UNION DENY OPEN UNIQUE DESC OPENDATASOURCE UNPIVOT DISK OPENQUERY UPDATE DISTINCT OPENROWSET UPDATETEXT DISTRIBUTED OPENXML USE DOUBLE OPTION USER DROP OR VALUES DUMP ORDER VARYING ELSE OUTER VIEW END OVER WAITFOR ERRLVL PERCENT WHEN ESCAPE PIVOT WHERE EXCEPT PLAN WHILE EXEC PRECISION WITH EXECUTE PRIMARY WITHIN GROUP EXISTS PRINT WRITETEXT EXIT PROC");
            SetKeywords(1, " add external procedure all fetch public alter file raiserror and fillfactor read any for readtext as foreign reconfigure asc freetext references authorization freetexttable replication backup from restore begin full restrict between function return break goto revert browse grant revoke bulk group right by having rollback cascade holdlock rowcount case identity rowguidcol check identity_insert rule checkpoint identitycol save close if schema clustered in securityaudit coalesce index select collate inner semantickeyphrasetable column insert semanticsimilaritydetailstable commit intersect semanticsimilaritytable compute into session_user constraint is set contains join setuser containstable key shutdown continue kill some convert left statistics create like system_user cross lineno table current load tablesample current_date merge textsize current_time national then current_timestamp nocheck to current_user nonclustered top cursor not tran database null transaction dbcc nullif trigger deallocate of truncate declare off try_convert default offsets tsequal delete on union deny open unique desc opendatasource unpivot disk openquery update distinct openrowset updatetext distributed openxml use double option user drop or values dump order varying else outer view end over waitfor errlvl percent when escape pivot where except plan while exec precision with execute primary within group exists print writetext exit proc");
        }
    }
}
