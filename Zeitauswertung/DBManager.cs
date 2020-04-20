using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitauswertung
{
    class DBManager
    {
        public Dictionary<string, Bearbeiter> dic_Bearbeiter;
        public Dictionary<string, Zeittyp> dic_Zeittypen;
        public DBManager()
        {
            GetBearbeiter();
            GetZeittypen();
        }

        private void GetBearbeiter()
        {
            dic_Bearbeiter = new Dictionary<string, Bearbeiter>();
            ISession session = GetSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<Bearbeiter>();
            crit.Add(Restrictions.IsNotNull("BearbeiterVorname"));
            List<Bearbeiter>LBearbeiter = (List<Bearbeiter>)crit.List<Bearbeiter>();
            
            //Object in String umwandeln
            foreach (Bearbeiter an in LBearbeiter)
            {
                dic_Bearbeiter.Add(an.BearbeiterVorname + " " + an.BearbeiterName, an);
            }


            CloseSession(session, tx);
        }

        private void GetZeittypen()
        {
            dic_Zeittypen = new Dictionary<string, Zeittyp>();

            ISession session = GetSession();
            ITransaction tx = session.BeginTransaction();

            ICriteria crit = session.CreateCriteria<Zeittyp>();
            List<Zeittyp>Zeittypen = (List<Zeittyp>)crit.List<Zeittyp>();
            
            //Object in String umwandeln
            foreach (Zeittyp an in Zeittypen)
            {                
                dic_Zeittypen.Add(an.Id, an);
            }
            CloseSession(session, tx);
        }

        public List<TableBuchung> GetBuchungen(Bearbeiter bearbeiter, DateTime von, DateTime bis)
        {
            ISession session = GetSession();
            ITransaction tx = session.BeginTransaction();

            
            //Tag abziehen
            von = von.AddDays(-1);
            //Tag hinzufügen
            bis = bis.AddDays(1);            

            ICriteria crit = session.CreateCriteria<Stundenbuchung>();
            crit.Add(Expression.Like(nameof(Stundenbuchung.Bearbeiter), bearbeiter.Id ));
            crit.Add(Expression.Between(nameof(Stundenbuchung.Datum), von, bis));            
             //crit.Add(Expression.Or(Expression.Between("DATE(Datum)", von, bis), Expression.Eq(nameof(Stundenbuchung.Datum), von.ToString(""))));
             //crit.Add(Expression.Or(Expression.Between(nameof(Stundenbuchung.Datum), von, bis), Expression.Eq(nameof(Stundenbuchung.Datum), von.ToString(""))));
             List <Stundenbuchung> buchungen = (List<Stundenbuchung>)crit.List<Stundenbuchung>();            
            
            CloseSession(session, tx);
            List<TableBuchung> tb = new List<TableBuchung>();
            foreach (Stundenbuchung b in buchungen)
            {
                tb.Add(new TableBuchung(b));
            }
            return tb;
        }

        #region Session
        private ISession GetSession()
        {
            var nhConfig = new Configuration().Configure();
            var sessionFactory = nhConfig.BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();
            sessionFactory.Close();
            return session;
        }

        private void CloseSession(ISession session, ITransaction tx)
        {
            session.Clear();
            tx.Dispose();
        }
        #endregion
    }
}
