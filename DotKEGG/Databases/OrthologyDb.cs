﻿namespace DotKEGG {

    /// <summary>
    /// Represents the <token>OrthologyDbLink</token> database.
    /// </summary>
    /// <inheritdoc/>
    public sealed class OrthologyDb : KeggDb {

        private static OrthologyDb s_instance = new OrthologyDb();

        private OrthologyDb() {
            Name = "orthology";
            Abbreviation = "ko";
            Prefix = "K";
        }

        /// <summary>
        /// <token>DbInstanceSummary</token>
        /// </summary>
        public static OrthologyDb Instance => s_instance;

        /// <include file='../../DotKEGG.Docs/IncludeFiles/Databases/KeggDb.xml' path='content/item[@name="OrthologyDbEntryComments"]/*'/>
        public static KNumber Orthology(uint number) => new KNumber(number);

        /// <inheritdoc/>
        public override KeggId Entry(uint number) => new KNumber(number);

    }

}
