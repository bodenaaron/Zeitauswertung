using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitauswertung
{
    class DBManager
    {
        public Dictionary<string, Bearbeiter> dic_Bearbeiter;
        public DBManager()
        {
            getBearbeiter();
            getZeittypen();
        }

        private void getBearbeiter()
        {
            ISession session = getSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<Bearbeiter>();
            crit.Add(Restrictions.IsNotNull("bearbeiterVorname"));
            dbPDF.bearbeiter = (List<Bearbeiter>)crit.List<Bearbeiter>();
            dbPDF.dic_Bearbeiter = new Dictionary<string, Bearbeiter>();
            //Object in String umwandeln
            foreach (Bearbeiter an in dbPDF.bearbeiter)
            {
                dbPDF.dic_Bearbeiter.Add(an.bearbeiterVorname + " " + an.bearbeiterName, an);
            }


            closeSession(session, tx);
        }

        private void getZeittypen()
        {

        }

        #region Session
        private ISession getSession()
        {
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            sessionFactory.Close();
            return session;
        }

        private void closeSession(ISession session, ITransaction tx)
        {
            session.Clear();
            tx.Dispose();
        }
        #endregion
    }
}
