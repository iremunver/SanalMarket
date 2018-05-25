using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriYapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList ll = new LinkedList();
        Tree tr = new Tree();
        HashTable h = new HashTable();
       
       

        private void btnUrunuEkle_Click(object sender, EventArgs e)
        {
            //if (txtUrunNumarasi.Text == "" || txtUrunAdi.Text == "" || txtMarka.Text == "" || txtModeli.Text == "" || txtMiktari.Text == "" || txtMaliyet.Text == "" || txtUrunAciklamasi.Text == ""||txtSatisFiyati.Text=="" );
               // MessageBox.Show("Lütfen Bütün Alanları Eksiksiz Doldurun");
            // else 
            //{
                Urun u = new Urun();
                Urun2 u2 = new Urun2();
                Urun3 u3 = new Urun3();
                u.Ad = txtUrunAdi.Text;
                u.Marka = txtMarka.Text;
                u.Model= txtModeli.Text;
                u.Miktar = Convert.ToInt32(txtMiktari.Text);
                u.Maliyet = Convert.ToInt32(txtMaliyet.Text);
                u.UrunAciklamasi = txtUrunAciklamasi.Text;
                u.UrunNo = Convert.ToInt32(txtUrunNumarasi.Text);
                u.BulunduguKategori =  cmbKategori.Text;
                u.SatisFiyati=Convert.ToDouble(txtSatisFiyati.Text);
                
                u2.llUrunNo = Convert.ToInt32(txtUrunNumarasi.Text);
                u2.Ad = txtUrunAdi.Text;
                u2.Marka = txtMarka.Text;
                u2.Model = txtModeli.Text;
                u2.Miktar = Convert.ToInt32(txtMiktari.Text);
                u2.BulunduguKategori = cmbKategori.Text;
                u2.Maliyet = Convert.ToInt32(txtMaliyet.Text);
                u2.Fiyat = Convert.ToDouble(txtSatisFiyati.Text);
                u2.UrunAciklamasi = txtUrunAciklamasi.Text;

                u3.Marka = txtMarka.Text;
                u3.Model = txtModeli.Text;
                u3.Miktar = Convert.ToInt32(txtMiktari.Text);
                u3.Maliyet = Convert.ToInt32(txtMaliyet.Text);
                u3.Ad = txtUrunAdi.Text;
                u3.hashUrunNo= Convert.ToInt32(txtUrunNumarasi.Text);
                u3.SatisFiyati = Convert.ToDouble(txtSatisFiyati.Text);
                u3.UrunAciklamasi = txtUrunAciklamasi.Text;
                u3.BulunduguKategori = cmbKategori.Text;

                
                    ll.Insert(u2);
                    tr.Ekle(u);
                    if (cmbKategori.Text == "Bilgisayar")
                        h.Ekle(1, u3);
                    else if (cmbKategori.Text == " Beyaz Eşya")
                        h.Ekle(2, u3);
                    else if (cmbKategori.Text == "Giyim")
                        h.Ekle(3, u3);
                    else if (cmbKategori.Text == "Kırtasiye Ofis")
                        h.Ekle(4, u3);
                    else if (cmbKategori.Text == "Yapı Market")
                        h.Ekle(5, u3);
                    else if (cmbKategori.Text == "Bahçe")
                        h.Ekle(6, u3);
                    else if (cmbKategori.Text == "Tekstil")
                        h.Ekle(7, u3);
                    else if (cmbKategori.Text == "Yiyecek")
                        h.Ekle(8, u3);
                    cmbUrunListesi.Items.Clear();
                    //cmbOgrNo.Items.Clear();
                    for (int i = 0; i < ll.Size; i++)
                    {
                        cmbUrunListesi.Items.Add(ll.GetElement(i + 1).llVeri.llUrunNo);
                        //cmbOgrNo.Items.Add(ll.GetElement(i + 1).llVeri.llOgrenciNo);
                    }
                    MessageBox.Show("Ürün başarı ile eklendi!");
                    txtUrunAdi.Clear();
                    txtUrunNumarasi.Clear();
                    txtMarka.Clear();
                    txtModeli.Clear();
                    txtMaliyet.Clear();
                    txtMiktari.Clear();
                    txtUrunAciklamasi.Clear();
                    txtSatisFiyati.Clear();
                
            }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            if (cmbUrunListesi.Text == "")
            {
                MessageBox.Show("Lütfen ürün Seçiniz");
            }
            else
            {
                int x = Convert.ToInt32(cmbUrunListesi.Text);
                int i = 1;
                for (; ; )
                {
                    if (ll.GetElement(i).llVeri.llUrunNo == x)
                        break;
                    else
                        i++;
                }
                txtUrunAdi.Text = tr.Ara(x).Veri.Ad;
                txtUrunNumarasi.Text = Convert.ToString(tr.Ara(x).Veri.UrunNo);
                txtMarka.Text = tr.Ara(x).Veri.Marka;
                txtModeli.Text = tr.Ara(x).Veri.Model;
                txtMiktari.Text = Convert.ToString(tr.Ara(x).Veri.Miktar);
                txtMaliyet.Text = Convert.ToString(tr.Ara(x).Veri.Maliyet);
                txtUrunAciklamasi.Text = tr.Ara(x).Veri.UrunAciklamasi;
                txtSatisFiyati.Text = Convert.ToString(tr.Ara(x).Veri.SatisFiyati);

               // txtUrunNumarasi.Text = Convert.ToString(ll.GetElement(i).llVeri.llUrunNo);
               // cmbKategori.Text = ll.GetElement(i).llVeri.BulunduguKategori;
               // txtUrunAdi.Text = ll.GetElement(i).llVeri.Ad;
               // txtMarka.Text = ll.GetElement(i).llVeri.Marka;
               // txtModeli.Text = ll.GetElement(i).llVeri.Model;
                MessageBox.Show("Ürün Getirildi!");
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                txtGuncellenecekUrun.Text = Convert.ToString(ll.GetElement(i).llVeri.llUrunNo);
                txtSilinecekUrun.Text = Convert.ToString(ll.GetElement(i).llVeri.llUrunNo);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {


                int i = 1;
                int guncelle = Convert.ToInt32(txtGuncellenecekUrun.Text);
                tr.Sil(guncelle);
                for (; ; )
                {
                    if (ll.GetElement(i).llVeri.llUrunNo == guncelle)
                        break;
                    else
                        i++;
                }
                ll.Delete(i);
                Urun u = new Urun();
                Urun2 u2 = new Urun2();
                u.Ad = txtUrunAdi.Text;
                u.Marka = txtMarka.Text;
                u.Model = txtModeli.Text;
                u.Miktar = Convert.ToInt32(txtMiktari.Text);
                u.Maliyet = Convert.ToInt32(txtMaliyet.Text);
                u.UrunAciklamasi = txtUrunAciklamasi.Text;
                u.UrunNo = Convert.ToInt32(txtUrunNumarasi.Text);
                u.SatisFiyati = Convert.ToDouble(txtSatisFiyati.Text);

                u2.llUrunNo = Convert.ToInt32(txtUrunNumarasi.Text);
                u2.BulunduguKategori = cmbKategori.Text;
   

                ll.Insert(u2);
                tr.Ekle(u);
                cmbUrunListesi.Items.Clear();
                //cmbOgrNo.Items.Clear();
                for (int j = 0; j < ll.Size; j++)
                {
                    cmbUrunListesi.Items.Add(ll.GetElement(j + 1).llVeri.llUrunNo);
                    //cmbOgrNo.Items.Add(ll.GetElement(j + 1).llVeri.llOgrenciNo);
                }
                MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellendi!");
            }

            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 1;
                int silinen = Convert.ToInt32(btnSil.Text);
                tr.Sil(silinen);
                for (; ; )
                {
                    if (ll.GetElement(i).llVeri.llUrunNo == silinen)
                        break;
                    else
                        i++;
                }
                ll.Delete(i);
                cmbUrunListesi.Items.Clear();
                //cmbOgrNo.Items.Clear();
                for (int j = 0; j < ll.Size; j++)
                {
                    cmbUrunListesi.Items.Add(ll.GetElement(j + 1).llVeri.llUrunNo);
                    //cmbOgrNo.Items.Add(ll.GetElement(j + 1).llVeri.llUrunNo);
                }
                MessageBox.Show("Silme İşlemi Başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.AdSoyad = txtAdSoyad.Text;
            m.TelefonNo = Convert.ToInt32(txtTelefonNo.Text);
            m.Email = txtEmail.Text;
        }

        private void btnAdArananUrun_Click(object sender, EventArgs e)
        {
            string gecici=null;
            LinkedListNode temp = ll.Head;

            while (temp != null)
            {
                if (temp.Next != null)
                {
                    if(temp.llVeri.Ad == txtArananUrunAd.Text)
                    {
                        gecici += "Ad: " + temp.llVeri.Ad + " Barkod: " + temp.llVeri.llUrunNo + " Fiyat: "  + temp.llVeri.Fiyat;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                    lbxAdiBulunanUrun.Items.Add(gecici);
                }   
                else
                    break;
            }           
        }

        
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            string gecici = null;
            LinkedListNode temp = ll.Head;

            while (temp != null)
            {
                if (temp.Next != null)
                {
                    if (temp.llVeri.llUrunNo.ToString() == txtSatilanUrunBarkod.Text)
                    {
                        gecici += "Ad: " + temp.llVeri.Ad + " Barkod: " + temp.llVeri.llUrunNo + " Fiyat: " + temp.llVeri.Fiyat;
                    }
                    else
                    {
                        temp = temp.Next;
                    }                  
                }
                else
                    break;
            }

        }

        private void btnAgacListele_Click(object sender, EventArgs e)
        {
            lblAgac.Items.Clear();
            if (cmbAgacSırala.Text == "")
            {
                MessageBox.Show("Geçerli Seçenek Seçiniz!");
            }
            else if (cmbAgacSırala.Text == "Inorder")
            {
                lblAgac.Items.Add(tr.InOrder());
            }
            else if (cmbAgacSırala.Text == "Preorder")
            {
                lblAgac.Items.Add(tr.PreOrder());
            }
            else if (cmbAgacSırala.Text == "Postorder")
            {
                lblAgac.Items.Add(tr.PostOrder());
            }
        }

        private void btnDerinlik_Click(object sender, EventArgs e)
        {
            txtDerinlik.Text = Convert.ToString(tr.DerinlikBul());
        }

        private void btnElemanSay_Click(object sender, EventArgs e)
        {
            txtElemanSay.Text = Convert.ToString(tr.DugumSayisi());
        }

        private void btnSepettenSil_Click(object sender, EventArgs e)
        {
            string gecici = null;
            LinkedListNode temp = ll.Head;

            while (temp != null)
            {
                if (temp.Next != null)
                {
                    if (temp.llVeri.llUrunNo.ToString() == txtSatilanUrunBarkod.Text)
                    {
                        gecici += "Ad: " + temp.llVeri.Ad + " Barkod: " + temp.llVeri.llUrunNo + " Fiyat: " + temp.llVeri.Fiyat;
                    }
                    lbxSepet.Items.Remove(gecici);
                    temp = temp.Next;
                }
                else
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        
        }


    }

