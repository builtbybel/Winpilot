namespace Winpilot
{
    // CoTweaker Base class
    public abstract class WalksBase
    {
        protected readonly MainForm _form;
        protected readonly Logger logger;

        public Logger Logger => logger;

        /* better short
        public Logger Logger
        {
            get { return logger; }
        } */

        protected WalksBase(MainForm form, Logger logger)
        {
            _form = form;
            this.logger = logger;
        }

        public abstract string ID();

        public abstract bool CheckFeature();

        public abstract bool DoFeature();

        public abstract bool UndoFeature();
    }
}