namespace Winpilot
{
    public abstract class InteropBase
    {
        protected readonly MainForm _form;
        protected readonly Logger logger;

        public Logger Logger => logger;

        public InteropBase(MainForm form, Logger logger)
        {
            _form = form;
            this.logger = logger;
        }

        public abstract void Execute();
    }
}