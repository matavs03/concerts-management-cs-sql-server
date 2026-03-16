using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Domen;

namespace BrokerBazePodataka
{
    public class Broker
    {
        DbConnection connection;

        private static Broker instance;

        private Broker()
        {
            connection = new DbConnection();
        }

        public static Broker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Broker();
                }
                return instance;
            }
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        #region Žanr

        public int InsertZanr(Zanr zanr)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Žanr_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Naziv", zanr.Naziv);

            int noviId = (int)cmd.ExecuteScalar();
            zanr.Id = noviId;
            return noviId;
        }

        public void UpdateZanr(Zanr zanr)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Žanr_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", zanr.Id);
            cmd.Parameters.AddWithValue("@Naziv", zanr.Naziv);

            cmd.ExecuteNonQuery();
        }

        public void DeleteZanr(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.sp_Žanr_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Zanr GetZanrById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Žanr_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Zanr
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };
            }

            return null;
        }

        public List<Zanr> GetAllZanrovi()
        {

            List<Zanr> zanrovi = new List<Zanr>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.sp_Žanr_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Zanr zanr = new Zanr
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };

                zanrovi.Add(zanr);
            }

            return zanrovi;
        }

        #endregion

        #region Izvođač

        public int InsertIzvodjac(Izvodjac izvodjac)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Izvođač_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email", izvodjac.Email);

            int noviId = (int)cmd.ExecuteScalar();
            izvodjac.Id = noviId;
            return noviId;
        }

        public void UpdateIzvodjac(Izvodjac izvodjac)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Izvođač_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", izvodjac.Id);
            cmd.Parameters.AddWithValue("@Email", izvodjac.Email);

            cmd.ExecuteNonQuery();
        }

        public void DeleteIzvodjac(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Izvođač_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Izvodjac GetIzvodjacById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Izvođač_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Izvodjac
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1)
                };
            }

            return null;
        }

        public List<Izvodjac> GetAllIzvodjaci()
        {
            List<Izvodjac> izvodjaci = new List<Izvodjac>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Izvođač_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Izvodjac izvodjac = new Izvodjac
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1)
                };

                izvodjaci.Add(izvodjac);
            }

            return izvodjaci;
        }

        #endregion

        #region IzvođačŽanr

        public void InsertIzvodjacZanr(int izvodjacId, int zanrId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.IzvođačŽanr_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);
            cmd.Parameters.AddWithValue("@ŽanrId", zanrId);

            cmd.ExecuteNonQuery();
        }

        public void DeleteIzvodjacZanr(int izvodjacId, int zanrId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.IzvođačŽanr_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);
            cmd.Parameters.AddWithValue("@ŽanrId", zanrId);

            cmd.ExecuteNonQuery();
        }

        public void DeleteAllZanroviForIzvodjac(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.IzvođačŽanr_DeleteAllByIzvođačId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            cmd.ExecuteNonQuery();
        }

        public List<Zanr> GetZanroviByIzvodjacId(int izvodjacId)
        {
            List<Zanr> zanrovi = new List<Zanr>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.IzvođačŽanr_GetByIzvođačId";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Zanr zanr = new Zanr
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };

                zanrovi.Add(zanr);
            }

            return zanrovi;
        }

        #endregion

        #region Muzičar

        public int InsertMuzicar(Muzicar muzicar)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Muzičar_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email", muzicar.Email);
            cmd.Parameters.AddWithValue("@Ime", muzicar.Ime);
            cmd.Parameters.AddWithValue("@Prezime", muzicar.Prezime);
            cmd.Parameters.AddWithValue("@Pol", muzicar.Pol.ToString());

            int noviId = (int)cmd.ExecuteScalar();
            muzicar.Id = noviId;
            return noviId;
        }

        public void UpdateMuzicar(Muzicar muzicar)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Muzičar_Update"; // Ovde smo obrisali sp_
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", muzicar.Id);
            cmd.Parameters.AddWithValue("@Email", muzicar.Email);
            cmd.Parameters.AddWithValue("@Ime", muzicar.Ime);
            cmd.Parameters.AddWithValue("@Prezime", muzicar.Prezime);
            cmd.Parameters.AddWithValue("@Pol", muzicar.Pol.ToString());

            cmd.ExecuteNonQuery();
        }

        public void DeleteMuzicar(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Muzičar_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            cmd.ExecuteNonQuery();
        }

        public Muzicar GetMuzicarById(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Muzičar_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Muzicar muzicar = new Muzicar
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Ime = reader.GetString(2),
                    Prezime = reader.GetString(3),
                    Pol = Enum.Parse<Pol>(reader.GetString(4).Trim())
                };

                return muzicar;
            }

            return null;
        }

        public List<Muzicar> GetAllMuzicari()
        {
            List<Muzicar> muzicari = new List<Muzicar>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Muzičar_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Muzicar muzicar = new Muzicar
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Ime = reader.GetString(2),
                    Prezime = reader.GetString(3),
                    Pol = Enum.Parse<Pol>(reader.GetString(4).Trim())
                };

                muzicari.Add(muzicar);
            }

            return muzicari;
        }

        #endregion

        #region Bend

        public int InsertBend(Bend bend)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Bend_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Email", bend.Email);
            cmd.Parameters.AddWithValue("@Naziv", bend.Naziv);
            cmd.Parameters.AddWithValue("@BrojČlanova", bend.BrojČlanova);

            int noviId = (int)cmd.ExecuteScalar();
            bend.Id = noviId;
            return noviId;
        }

        public void UpdateBend(Bend bend)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Bend_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", bend.Id);
            cmd.Parameters.AddWithValue("@Email", bend.Email);
            cmd.Parameters.AddWithValue("@Naziv", bend.Naziv);
            cmd.Parameters.AddWithValue("@BrojČlanova", bend.BrojČlanova);

            cmd.ExecuteNonQuery();
        }

        public void DeleteBend(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Bend_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            cmd.ExecuteNonQuery();
        }

        public Bend GetBendById(int izvodjacId)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Bend_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzvođačId", izvodjacId);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Bend bend = new Bend
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Naziv = reader.GetString(2),
                    BrojČlanova = reader.GetInt32(3)
                };

                return bend;
            }

            return null;
        }

        public List<Bend> GetAllBendovi()
        {
            List<Bend> bendovi = new List<Bend>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Izvodjaci.Bend_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bend bend = new Bend
                {
                    Id = reader.GetInt32(0),
                    Email = reader.GetString(1),
                    Naziv = reader.GetString(2),
                    BrojČlanova = reader.GetInt32(3)
                };

                bendovi.Add(bend);
            }

            return bendovi;
        }

        #endregion

        #region Grad

        public int InsertGrad(Grad grad)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.Grad_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Naziv", grad.Naziv);

            int noviId = (int)cmd.ExecuteScalar();
            grad.Id = noviId;
            return noviId;
        }

        public void UpdateGrad(Grad grad)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.Grad_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", grad.Id);
            cmd.Parameters.AddWithValue("@Naziv", grad.Naziv);

            cmd.ExecuteNonQuery();
        }

        public void DeleteGrad(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.Grad_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Grad GetGradById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.Grad_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new Grad
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };
            }

            return null;
        }

        public List<Grad> GetAllGradovi()
        {
            List<Grad> gradovi = new List<Grad>();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.Grad_GetAll";
            cmd.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Grad grad = new Grad
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1)
                };

                gradovi.Add(grad);
            }

            return gradovi;
        }

        #endregion

        #region Lokacija

        public int InsertLokacija(Lokacija lokacija)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.sp_Lokacija_Insert";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Naziv", lokacija.Naziv);
            cmd.Parameters.AddWithValue("@Adresa", lokacija.Adresa);
            cmd.Parameters.AddWithValue("@Kapacitet", lokacija.Kapacitet);
            cmd.Parameters.AddWithValue("@GradId", lokacija.grad.Id);

            int noviId = (int)cmd.ExecuteScalar();
            lokacija.id = noviId;

            return noviId;
        }

        public void UpdateLokacija(Lokacija lokacija)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.Lokacija_Update";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", lokacija.id);
            cmd.Parameters.AddWithValue("@Naziv", lokacija.Naziv);
            cmd.Parameters.AddWithValue("@Adresa", lokacija.Adresa);
            cmd.Parameters.AddWithValue("@Kapacitet", lokacija.Kapacitet);
            cmd.Parameters.AddWithValue("@GradId", lokacija.grad.Id);

            cmd.ExecuteNonQuery();
        }

        public void DeleteLokacija(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.Lokacija_Delete";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
        }

        public Lokacija GetLokacijaById(int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Lokacije.sp_Lokacija_GetById";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Grad g = new Grad
                {
                    Id = reader.GetInt32(4),
                    Naziv = reader.GetString(5)
                };

                Lokacija lokacija = new Lokacija
                {
                    id = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    Adresa = reader.GetString(2),
                    Kapacitet = reader.GetInt32(3),
                    grad = g
                };

                return lokacija;
            }

            return null;
        }

        public List<Lokacija> GetAllLokacije()
        {
            List<Lokacija> lokacije = new List<Lokacija>();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Lokacije.Lokacija_GetAll";
            command.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Grad g = new Grad
                {
                    Id = (int)reader["GradId"],
                    Naziv = (string)reader["GradNaziv"]
                };

                Lokacija l = new Lokacija
                {
                    id = (int)reader["Id"],
                    LokacijaId = (int)reader["Id"],
                    Naziv = (string)reader["Naziv"],
                    Adresa = (string)reader["Adresa"],
                    Kapacitet = (int)reader["Kapacitet"],
                    grad = g
                };

                lokacije.Add(l);
            }

            return lokacije;
        }

        #endregion

        #region Koncert
        public List<Koncert> GetAllKoncerti()
        {
            List<Koncert> koncerti = new List<Koncert>();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Prodaja.Koncert_GetAllPrikaz";
            command.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Grad g = new Grad
                {
                    Id = (int)reader["GradId"],
                    Naziv = (string)reader["NazivGrada"]
                };

                Lokacija l = new Lokacija
                {
                    LokacijaId = (int)reader["LokacijaId"],
                    Naziv = (string)reader["NazivLokacije"],
                    Adresa = (string)reader["Adresa"],
                    Kapacitet = (int)reader["Kapacitet"],
                    grad = g
                };

                Izvodjac izvodjac;

                if (reader["NazivBenda"] != DBNull.Value)
                {
                    izvodjac = new Bend
                    {
                        Id = (int)reader["IzvođačId"],
                        Email = (string)reader["IzvođačEmail"],
                        Naziv = (string)reader["NazivBenda"],
                        BrojČlanova = (int)reader["BrojČlanova"]
                    };
                }
                else
                {
                    izvodjac = new Muzicar
                    {
                        Id = (int)reader["IzvođačId"],
                        Email = (string)reader["IzvođačEmail"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Pol = reader["Pol"].ToString().Trim() == "M" ? Pol.M : Pol.Ž
                    };
                }

                Koncert k = new Koncert
                {
                    izvodjac = izvodjac,
                    lokacija = l,
                    Naziv = (string)reader["NazivKoncerta"],
                    Datum = (DateTime)reader["Datum"],
                    VremeTrajanja = (int)reader["VremeTrajanja"],
                    Status = Enum.Parse<Status>((string)reader["Status"]),
                    VremePocetka = (TimeSpan)reader["VremePočetka"]
                };

                koncerti.Add(k);
            }

            return koncerti;
        }
        public void DeleteKoncert(object izvodjacId, int lokacijaId, DateTime datum)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Prodaja.Koncert_Delete";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IzvođačId", izvodjacId);
            command.Parameters.AddWithValue("@LokacijaId", lokacijaId);
            command.Parameters.AddWithValue("@Datum", datum);

            command.ExecuteNonQuery();
        }
        public void DodajKoncert(Koncert koncert)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Prodaja.Koncert_Insert";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IzvođačId", koncert.izvodjac.Id);
            command.Parameters.AddWithValue("@LokacijaId", koncert.lokacija.LokacijaId);
            command.Parameters.AddWithValue("@Datum", koncert.Datum.Date);
            command.Parameters.AddWithValue("@Status", koncert.Status.ToString());
            command.Parameters.AddWithValue("@VremeTrajanja", koncert.VremeTrajanja);
            command.Parameters.AddWithValue("@VremePočetka", koncert.VremePocetka);
            command.Parameters.AddWithValue("@Naziv", koncert.Naziv);

            command.ExecuteNonQuery();
        }


        public List<Izvodjac> GetAllIzvodjaciPrikaz()
        {
            List<Izvodjac> izvodjaci = new List<Izvodjac>();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Izvodjaci.Izvođač_GetAllPrikaz";
            command.CommandType = CommandType.StoredProcedure;

            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Izvodjac izvodjac;

                if (reader["NazivBenda"] != DBNull.Value)
                {
                    izvodjac = new Bend
                    {
                        Id = (int)reader["Id"],
                        Email = (string)reader["Email"],
                        Naziv = (string)reader["NazivBenda"],
                        BrojČlanova = (int)reader["BrojČlanova"]
                    };
                }
                else
                {
                    izvodjac = new Muzicar
                    {
                        Id = (int)reader["Id"],
                        Email = (string)reader["Email"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Pol = reader["Pol"].ToString().Trim() == "M" ? Pol.M : Pol.Ž
                    };
                }

                izvodjaci.Add(izvodjac);
            }

            return izvodjaci;
        }

        public void UpdateKoncert(Koncert stari, Koncert novi)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Prodaja.Koncert_Update";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IzvođačId", stari.izvodjac.Id);
            command.Parameters.AddWithValue("@LokacijaId", stari.lokacija.LokacijaId);
            command.Parameters.AddWithValue("@StariDatum", stari.Datum.Date);

            command.Parameters.AddWithValue("@NoviDatum", novi.Datum);

            command.Parameters.AddWithValue("@Status", novi.Status.ToString());
            command.Parameters.AddWithValue("@VremeTrajanja", novi.VremeTrajanja);
            command.Parameters.Add("@VremePočetka", SqlDbType.Time).Value = novi.VremePocetka;
            command.Parameters.AddWithValue("@Naziv", novi.Naziv);

            command.ExecuteNonQuery();
        }


        #endregion


        #region Karta
        public void InsertKarta(Karta karta)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Prodaja.Karta_Insert";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IzvođačId", karta.Koncert.izvodjac.Id);
            command.Parameters.AddWithValue("@LokacijaId", karta.Koncert.lokacija.LokacijaId);
            command.Parameters.AddWithValue("@Datum", karta.Koncert.Datum.Date);
            command.Parameters.AddWithValue("@Red", karta.Red);
            command.Parameters.AddWithValue("@Sedište", karta.Sediste);

            command.ExecuteNonQuery();
        }
        #endregion
    }
}