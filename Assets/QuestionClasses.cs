using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionClasses : MonoBehaviour
{
    public static QuestionClasses instance;

    void Awake()
    {
        instance = this;
    }

    [System.Serializable]
    public class Question
    {
        public string question;
        public List<string> answerButton;
        public int AnswerOnButton;

        public Question(string question, List<string> answerButton, int AnswerOnButton)
        {
            this.question = question;
            this.answerButton = answerButton;
            this.AnswerOnButton = AnswerOnButton;
        }
    }

    [System.Serializable]
    public class Levels
    {
        public List<Question> questions = new List<Question>();
    }

    public List<Levels> levels;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("InsertClasses", 2f);
    }

    public void InsertClasses()
    {
        levels.AddRange(
            new List<Levels>
            {
                //level 1
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Kita bernafas menggunakan…",
                            new List<string> { "Hidung", "Mata" },
                            0 // index of "Hidung"
                        ),
                        new Question(
                            "Deria rasa menggunakan…",
                            new List<string> { "Lidah", "Telinga" },
                            0 // index of "Lidah"
                        ),
                        new Question(
                            "Deria penglihatan menggunakan…",
                            new List<string> { "Mata", "Hidung" },
                            0 // index of "Mata"
                        ),
                        new Question(
                            "Kita berjalan menggunakan…",
                            new List<string> { "Kaki", "Tangan" },
                            0 // index of "Kaki"
                        ),
                        new Question(
                            "Deria bau menggunakan…",
                            new List<string> { "Hidung", "Mulut" },
                            0 // index of "Hidung"
                        ),
                        new Question(
                            "Telinga digunakan untuk…",
                            new List<string> { "Mendengar", "Melihat" },
                            0 // index of "Mendengar"
                        ),
                        new Question(
                            "Kita menulis menggunakan…",
                            new List<string> { "Kaki", "Tangan" },
                            1 // index of "Tangan"
                        ),
                        new Question(
                            "Deria sentuhan menggunakan…",
                            new List<string> { "Kulit", "Rambut" },
                            0 // index of "Kulit"
                        ),
                        new Question(
                            "Rambut tumbuh di…",
                            new List<string> { "Kepala", "Kaki" },
                            0 // index of "Kepala"
                        ),
                        new Question(
                            "Kita melihat bola menggunakan…",
                            new List<string> { "Mata", "Hidung" },
                            0 // index of "Mata"
                        ),
                        new Question(
                            "Kita merasai makanan pedas dengan…",
                            new List<string> { "Lidah", "Telinga" },
                            0 // index of "Lidah"
                        ),
                        new Question(
                            "Untuk menghidu bunga, kita guna…",
                            new List<string> { "Hidung", "Mata" },
                            0 // index of "Hidung"
                        ),
                        new Question(
                            "Kulit membolehkan kita merasai…",
                            new List<string> { "Panas", "Bunyi" },
                            0 // index of "Panas"
                        ),
                        new Question(
                            "Kita mengunyah makanan dengan…",
                            new List<string> { "Gigi", "Kaki" },
                            0 // index of "Gigi"
                        ),
                        new Question(
                            "Untuk mendengar muzik, kita guna…",
                            new List<string> { "Mata", "Telinga" },
                            1 // index of "Telinga"
                        ),
                        new Question(
                            "Kita memegang pensel dengan…",
                            new List<string> { "Tangan", "Kaki" },
                            0 // index of "Tangan"
                        ),
                        new Question(
                            "Deria rasa dapat mengesan rasa…",
                            new List<string> { "Masin", "Kuat" },
                            0 // index of "Masin"
                        ),
                        new Question(
                            "Kita melihat pelangi dengan…",
                            new List<string> { "Mata", "Hidung" },
                            0 // index of "Mata"
                        ),
                        new Question(
                            "Untuk merasai air sejuk, kita guna…",
                            new List<string> { "Kulit", "Hidung" },
                            0 // index of "Kulit"
                        ),
                        new Question(
                            "Hidung digunakan untuk…",
                            new List<string> { "Menghidu", "Melihat" },
                            0 // index of "Menghidu"
                        ),
                    },
                },
                //level 2
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Kita bernafas menggunakan…",
                            new List<string> { "Hidung", "Mata" },
                            0
                        ),
                        new Question(
                            "Deria rasa menggunakan…",
                            new List<string> { "Lidah", "Telinga" },
                            0
                        ),
                        new Question(
                            "Deria penglihatan menggunakan…",
                            new List<string> { "Mata", "Hidung" },
                            0
                        ),
                        new Question(
                            "Kita berjalan menggunakan…",
                            new List<string> { "Kaki", "Tangan" },
                            0
                        ),
                        new Question(
                            "Deria bau menggunakan…",
                            new List<string> { "Hidung", "Mulut" },
                            0
                        ),
                        new Question(
                            "Telinga digunakan untuk…",
                            new List<string> { "Mendengar", "Melihat" },
                            0
                        ),
                        new Question(
                            "Kita menulis menggunakan…",
                            new List<string> { "Kaki", "Tangan" },
                            1
                        ),
                        new Question(
                            "Deria sentuhan menggunakan…",
                            new List<string> { "Kulit", "Rambut" },
                            0
                        ),
                        new Question("Rambut tumbuh di…", new List<string> { "Kepala", "Kaki" }, 0),
                        new Question(
                            "Kita melihat bola menggunakan…",
                            new List<string> { "Mata", "Hidung" },
                            0
                        ),
                        new Question(
                            "Kita merasai makanan pedas dengan…",
                            new List<string> { "Lidah", "Telinga" },
                            0
                        ),
                        new Question(
                            "Untuk menghidu bunga, kita guna…",
                            new List<string> { "Hidung", "Mata" },
                            0
                        ),
                        new Question(
                            "Kulit membolehkan kita merasai…",
                            new List<string> { "Panas", "Bunyi" },
                            0
                        ),
                        new Question(
                            "Kita mengunyah makanan dengan…",
                            new List<string> { "Gigi", "Kaki" },
                            0
                        ),
                        new Question(
                            "Untuk mendengar muzik, kita guna…",
                            new List<string> { "Mata", "Telinga" },
                            1
                        ),
                        new Question(
                            "Kita memegang pensel dengan…",
                            new List<string> { "Tangan", "Kaki" },
                            0
                        ),
                        new Question(
                            "Deria rasa dapat mengesan rasa…",
                            new List<string> { "Masin", "Kuat" },
                            0
                        ),
                        new Question(
                            "Kita melihat pelangi dengan…",
                            new List<string> { "Mata", "Hidung" },
                            0
                        ),
                        new Question(
                            "Untuk merasai air sejuk, kita guna…",
                            new List<string> { "Kulit", "Hidung" },
                            0
                        ),
                        new Question(
                            "Hidung digunakan untuk…",
                            new List<string> { "Menghidu", "Melihat" },
                            0
                        ),
                    },
                },
                // Level 3: Cuaca dan Alam Sekitar
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Cuaca yang panas biasanya ada…",
                            new List<string> { "Matahari", "Hujan" },
                            0
                        ),
                        new Question(
                            "Hari hujan biasanya berawan dan…",
                            new List<string> { "Berpetir", "Berangin" },
                            1
                        ),
                        new Question("Awan berwarna…", new List<string> { "Putih", "Hijau" }, 0),
                        new Question(
                            "Hujan turun daripada…",
                            new List<string> { "Awan", "Pokok" },
                            0
                        ),
                        new Question(
                            "Cuaca berangin boleh membuat…",
                            new List<string> { "Pokok bergoyang", "Air membeku" },
                            0
                        ),
                        new Question(
                            "Payung digunakan ketika…",
                            new List<string> { "Hujan", "Panas" },
                            0
                        ),
                        new Question(
                            "Baju hujan dipakai untuk…",
                            new List<string> { "Melindungi daripada hujan", "Mengeringkan baju" },
                            0
                        ),
                        new Question(
                            "Hari panas sesuai untuk…",
                            new List<string> { "Menjemur pakaian", "Memakai baju hujan" },
                            0
                        ),
                        new Question(
                            "Pelangi biasanya muncul selepas…",
                            new List<string> { "Hujan", "Angin kencang" },
                            0
                        ),
                        new Question(
                            "Angin kencang boleh menerbangkan…",
                            new List<string> { "Layang-layang", "Batu besar" },
                            0
                        ),
                        new Question(
                            "Kita menjaga alam sekitar dengan…",
                            new List<string>
                            {
                                "Membuang sampah di tempatnya",
                                "Membuang sampah merata-rata",
                            },
                            0
                        ),
                        new Question(
                            "Pokok memberi kita…",
                            new List<string> { "Oksigen", "Plastik" },
                            0
                        ),
                        new Question(
                            "Sungai yang bersih sesuai untuk…",
                            new List<string> { "Memelihara ikan", "Membuang sampah" },
                            0
                        ),
                        new Question(
                            "Membuang minyak ke dalam sungai akan…",
                            new List<string> { "Mencemarkan air", "Menyuburkan tanah" },
                            0
                        ),
                        new Question(
                            "Kita perlu menanam…",
                            new List<string> { "Pokok", "Plastik" },
                            0
                        ),
                        new Question(
                            "Menjaga kebersihan udara membantu kita…",
                            new List<string> { "Sihat", "Sakit" },
                            0
                        ),
                        new Question(
                            "Menutup pili air selepas digunakan dapat…",
                            new List<string> { "Menjimatkan air", "Membazirkan air" },
                            0
                        ),
                        new Question(
                            "Memotong pokok tanpa kawalan boleh menyebabkan…",
                            new List<string> { "Hakisan tanah", "Udara segar" },
                            0
                        ),
                        new Question(
                            "Udara bersih bebas daripada…",
                            new List<string> { "Asap", "Oksigen" },
                            0
                        ),
                        new Question(
                            "Tempat yang bersih adalah tempat yang…",
                            new List<string> { "Tidak berbau busuk", "Banyak sampah" },
                            0
                        ),
                    },
                },
                // Level 4: Keluarga dan Rumah
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Keluarga terdiri daripada ibu, bapa dan…",
                            new List<string> { "Anak", "Haiwan peliharaan" },
                            0
                        ),
                        new Question(
                            "Ibu bertugas untuk…",
                            new List<string> { "Memasak", "Membina jalan raya" },
                            0
                        ),
                        new Question(
                            "Ayah biasanya membantu…",
                            new List<string>
                            {
                                "Menjaga keselamatan keluarga",
                                "Menanam padi sahaja",
                            },
                            0
                        ),
                        new Question(
                            "Abang atau kakak boleh membantu…",
                            new List<string> { "Mengemas rumah", "Memotong pokok besar" },
                            0
                        ),
                        new Question(
                            "Adik memerlukan…",
                            new List<string> { "Kasih sayang", "Lesen memandu" },
                            0
                        ),
                        new Question(
                            "Rumah melindungi kita daripada…",
                            new List<string> { "Cuaca buruk", "Makanan" },
                            0
                        ),
                        new Question(
                            "Tingkat rumah digunakan untuk…",
                            new List<string> { "Mendapat cahaya dan udara", "Menyimpan pakaian" },
                            0
                        ),
                        new Question(
                            "Bilik tidur digunakan untuk…",
                            new List<string> { "Berehat", "Memasak" },
                            0
                        ),
                        new Question(
                            "Dapur digunakan untuk…",
                            new List<string> { "Memasak", "Menyimpan kasut" },
                            0
                        ),
                        new Question(
                            "Bilik air digunakan untuk…",
                            new List<string> { "Mandi", "Menonton televisyen" },
                            0
                        ),
                        new Question(
                            "Kita mesti menjaga kebersihan rumah supaya…",
                            new List<string> { "Sihat", "Sakit" },
                            0
                        ),
                        new Question(
                            "Menyapu lantai dapat…",
                            new List<string> { "Menghilangkan habuk", "Menambah habuk" },
                            0
                        ),
                        new Question(
                            "Memastikan perabot tersusun dapat…",
                            new List<string> { "Elakkan kemalangan", "Menyempitkan ruang" },
                            0
                        ),
                        new Question(
                            "Lampu digunakan untuk…",
                            new List<string> { "Menerangi rumah", "Memasak nasi" },
                            0
                        ),
                        new Question(
                            "Kerusi digunakan untuk…",
                            new List<string> { "Duduk", "Tidur" },
                            0
                        ),
                        new Question(
                            "Kipas digunakan untuk…",
                            new List<string> { "Menyejukkan udara", "Memanaskan badan" },
                            0
                        ),
                        new Question(
                            "Menutup suis selepas digunakan dapat…",
                            new List<string> { "Menjimatkan elektrik", "Membazirkan elektrik" },
                            0
                        ),
                        new Question(
                            "Kita perlu menghormati…",
                            new List<string> { "Ahli keluarga", "Barang rosak" },
                            0
                        ),
                        new Question(
                            "Rumah yang bersih adalah rumah yang…",
                            new List<string> { "Selamat", "Berdebu" },
                            0
                        ),
                        new Question(
                            "Kita perlu bekerjasama di rumah supaya…",
                            new List<string> { "Kerja cepat siap", "Rumah kotor" },
                            0
                        ),
                    },
                },
                // Level 5: Kesihatan dan Kebersihan Diri
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Kita perlu memberus gigi sekurang-kurangnya…",
                            new List<string>
                            {
                                "Sekali sehari",
                                "Dua kali sehari",
                                "Tiga kali sehari",
                                "Empat kali sehari",
                            },
                            1
                        ),
                        new Question(
                            "Sebelum makan, kita perlu…",
                            new List<string>
                            {
                                "Basuh tangan",
                                "Berlari",
                                "Minum air",
                                "Gosok rambut",
                            },
                            0
                        ),
                        new Question(
                            "Kebersihan badan dapat mencegah…",
                            new List<string>
                            {
                                "Penyakit",
                                "Hujan",
                                "Panas terik",
                                "Tumbuh tinggi",
                            },
                            0
                        ),
                        new Question(
                            "Alat yang digunakan untuk membersihkan gigi ialah…",
                            new List<string> { "Sabun", "Berus gigi", "Sikat rambut", "Tuala" },
                            1
                        ),
                        new Question(
                            "Mandi sekurang-kurangnya…",
                            new List<string>
                            {
                                "Sekali sehari",
                                "Dua kali sehari",
                                "Tiga kali sehari",
                                "Empat kali sehari",
                            },
                            1
                        ),
                        new Question(
                            "Memotong kuku dapat mengelakkan…",
                            new List<string>
                            {
                                "Rambut gugur",
                                "Jangkitan kuman",
                                "Demam panas",
                                "Kulit kering",
                            },
                            1
                        ),
                        new Question(
                            "Apakah minuman yang baik untuk kesihatan?",
                            new List<string> { "Air sirap", "Air kosong", "Air bergas", "Kopi" },
                            1
                        ),
                        new Question(
                            "Apabila bersin, kita perlu…",
                            new List<string>
                            {
                                "Menutup mulut dan hidung",
                                "Menjerit kuat-kuat",
                                "Berlari keluar",
                                "Ketawa",
                            },
                            0
                        ),
                        new Question(
                            "Memakai pakaian yang bersih dapat…",
                            new List<string>
                            {
                                "Membuat kita sakit",
                                "Memberi keselesaan",
                                "Membuat kita mengantuk",
                                "Menghalang kita makan",
                            },
                            1
                        ),
                        new Question(
                            "Sebelum tidur, kita perlu…",
                            new List<string>
                            {
                                "Basuh tangan",
                                "Gosok gigi",
                                "Minum kopi",
                                "Menonton televisyen",
                            },
                            1
                        ),
                        new Question(
                            "Makanan yang sihat perlu mengandungi…",
                            new List<string>
                            {
                                "Gula sahaja",
                                "Garam sahaja",
                                "Pelbagai nutrien",
                                "Minyak sahaja",
                            },
                            2
                        ),
                        new Question(
                            "Apakah yang perlu dilakukan selepas bermain di luar?",
                            new List<string>
                            {
                                "Terus makan",
                                "Basuh tangan dan kaki",
                                "Tidur",
                                "Tukar kasut",
                            },
                            1
                        ),
                        new Question(
                            "Untuk mengelakkan penyakit, kita perlu…",
                            new List<string>
                            {
                                "Makan berlebihan",
                                "Menjaga kebersihan",
                                "Tidak mandi",
                                "Minum air bergas",
                            },
                            1
                        ),
                        new Question(
                            "Kasut sekolah perlu dibersihkan…",
                            new List<string>
                            {
                                "Setiap minggu",
                                "Setiap bulan",
                                "Setiap tahun",
                                "Tidak perlu dibersihkan",
                            },
                            0
                        ),
                        new Question(
                            "Apakah yang patut digunakan untuk mencuci tangan?",
                            new List<string>
                            {
                                "Air sahaja",
                                "Air dan sabun",
                                "Minyak masak",
                                "Air bergas",
                            },
                            1
                        ),
                        new Question(
                            "Menjaga kebersihan rumah dapat mengelakkan…",
                            new List<string>
                            {
                                "Tumbesaran",
                                "Penyakit",
                                "Cahaya matahari",
                                "Hujan",
                            },
                            1
                        ),
                        new Question(
                            "Apakah yang perlu dilakukan selepas menggunakan tandas?",
                            new List<string>
                            {
                                "Basuh tangan dengan sabun",
                                "Minum air",
                                "Sikat rambut",
                                "Makan",
                            },
                            0
                        ),
                        new Question(
                            "Kita perlu menutup mulut ketika…",
                            new List<string> { "Minum", "Bersin", "Makan", "Menyanyi" },
                            1
                        ),
                        new Question(
                            "Menyimpan makanan di tempat tertutup dapat mengelakkan…",
                            new List<string>
                            {
                                "Bau wangi",
                                "Serangga dan kuman",
                                "Makanan rosak cepat",
                                "Minuman tumpah",
                            },
                            1
                        ),
                        new Question(
                            "Amalan kesihatan yang baik membantu kita…",
                            new List<string>
                            {
                                "Mudah sakit",
                                "Kekal sihat",
                                "Cepat penat",
                                "Susah tidur",
                            },
                            1
                        ),
                    },
                },
                //Level 6: Alam Semula Jadi
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Apakah sumber cahaya semula jadi?",
                            new List<string> { "Lampu suluh", "Matahari", "Lilin", "Lampu jalan" },
                            1
                        ),
                        new Question(
                            "Air sungai adalah contoh…",
                            new List<string>
                            {
                                "Bahan buatan manusia",
                                "Sumber semula jadi",
                                "Peralatan dapur",
                                "Makanan",
                            },
                            1
                        ),
                        new Question(
                            "Angin bergerak dari kawasan…",
                            new List<string>
                            {
                                "Panas ke panas",
                                "Sejuk ke panas",
                                "Sejuk ke sejuk",
                                "Panas ke sejuk",
                            },
                            1
                        ),
                        new Question(
                            "Apakah warna langit pada waktu siang yang cerah?",
                            new List<string> { "Biru", "Hijau", "Kuning", "Merah" },
                            0
                        ),
                        new Question(
                            "Batu, pasir, dan tanah ialah contoh…",
                            new List<string>
                            {
                                "Haiwan",
                                "Benda bukan hidup",
                                "Tumbuhan",
                                "Makanan",
                            },
                            1
                        ),
                        new Question(
                            "Apakah kegunaan matahari kepada tumbuhan?",
                            new List<string>
                            {
                                "Menghasilkan cahaya lampu",
                                "Membantu membuat makanan",
                                "Memberi hujan",
                                "Menghasilkan angin",
                            },
                            1
                        ),
                        new Question(
                            "Hujan turun dari…",
                            new List<string> { "Tanah", "Pokok", "Awan", "Sungai" },
                            2
                        ),
                        new Question(
                            "Sumber udara yang bersih membantu kita…",
                            new List<string> { "Tidur", "Bernafas", "Menulis", "Membaca" },
                            1
                        ),
                        new Question(
                            "Contoh air yang bersih ialah…",
                            new List<string>
                            {
                                "Air longkang",
                                "Air parit",
                                "Air perigi",
                                "Air banjir",
                            },
                            2
                        ),
                        new Question(
                            "Bulan dapat dilihat dengan jelas pada waktu…",
                            new List<string> { "Pagi", "Petang", "Malam", "Tengah hari" },
                            2
                        ),
                        new Question(
                            "Apakah yang berlaku jika kita memotong pokok tanpa menanam semula?",
                            new List<string>
                            {
                                "Udara menjadi segar",
                                "Kekurangan oksigen",
                                "Lebih banyak teduhan",
                                "Hujan turun lebih kerap",
                            },
                            1
                        ),
                        new Question(
                            "Apakah kebaikan menjaga sungai?",
                            new List<string>
                            {
                                "Mengurangkan air",
                                "Memastikan air bersih",
                                "Membuat sampah banyak",
                                "Menarik nyamuk",
                            },
                            1
                        ),
                        new Question(
                            "Benda hidup memerlukan…",
                            new List<string>
                            {
                                "Televisyen",
                                "Telefon",
                                "Air, udara, dan makanan",
                                "Kereta",
                            },
                            2
                        ),
                        new Question(
                            "Benda bukan hidup tidak memerlukan…",
                            new List<string> { "Cahaya", "Air", "Makanan", "Udara" },
                            2
                        ),
                        new Question(
                            "Angin yang bertiup kuat dipanggil…",
                            new List<string> { "Bayu", "Ribut", "Hujan", "Ombak" },
                            1
                        ),
                        new Question(
                            "Apakah sumber tenaga utama di Bumi?",
                            new List<string> { "Bulan", "Matahari", "Api", "Elektrik" },
                            1
                        ),
                        new Question(
                            "Bunga berkembang dengan bantuan…",
                            new List<string> { "Bulan", "Cahaya matahari", "Hujan batu", "Petir" },
                            1
                        ),
                        new Question(
                            "Air hujan boleh digunakan untuk…",
                            new List<string>
                            {
                                "Minum tanpa dimasak",
                                "Menyiram tanaman",
                                "Menghasilkan api",
                                "Menghasilkan angin",
                            },
                            1
                        ),
                        new Question(
                            "Apakah yang membantu menghalang hakisan tanah?",
                            new List<string>
                            {
                                "Memotong rumput",
                                "Menanam pokok",
                                "Membuang sampah",
                                "Membina jalan",
                            },
                            1
                        ),
                        new Question(
                            "Apakah yang akan berlaku jika udara tercemar?",
                            new List<string>
                            {
                                "Udara menjadi segar",
                                "Manusia boleh jatuh sakit",
                                "Haiwan bertambah",
                                "Tumbuhan membesar dengan cepat",
                            },
                            1
                        ),
                    },
                },
                //Level 7: Teknologi Di Sekeliling Kita
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Apakah yang digunakan untuk bercakap dengan orang jauh?",
                            new List<string> { "Buku", "Telefon", "Kasut", "Basikal" },
                            1
                        ),
                        new Question(
                            "Mesin basuh digunakan untuk…",
                            new List<string>
                            {
                                "Memasak nasi",
                                "Membasuh pakaian",
                                "Memotong rumput",
                                "Menggali tanah",
                            },
                            1
                        ),
                        new Question(
                            "Televisyen digunakan untuk…",
                            new List<string>
                            {
                                "Membaca buku",
                                "Menonton rancangan",
                                "Memasak",
                                "Menyiram pokok",
                            },
                            1
                        ),
                        new Question(
                            "Komputer boleh digunakan untuk…",
                            new List<string>
                            {
                                "Menyapu lantai",
                                "Mencari maklumat",
                                "Mengangkat barang",
                                "Memotong sayur",
                            },
                            1
                        ),
                        new Question(
                            "Kenderaan yang bergerak di atas jalan raya ialah…",
                            new List<string>
                            {
                                "Kapal terbang",
                                "Kereta",
                                "Kapal layar",
                                "Kapal selam",
                            },
                            1
                        ),
                        new Question(
                            "Peti sejuk digunakan untuk…",
                            new List<string>
                            {
                                "Memanaskan makanan",
                                "Menyimpan makanan agar tahan lama",
                                "Membasuh pinggan",
                                "Menggiling tepung",
                            },
                            1
                        ),
                        new Question(
                            "Apakah teknologi yang digunakan untuk mengambil gambar?",
                            new List<string>
                            {
                                "Lampu suluh",
                                "Kamera",
                                "Kalkulator",
                                "Telefon awam",
                            },
                            1
                        ),
                        new Question(
                            "Blender digunakan untuk…",
                            new List<string>
                            {
                                "Memasak",
                                "Mengisar makanan",
                                "Membasuh pakaian",
                                "Menyapu lantai",
                            },
                            1
                        ),
                        new Question(
                            "Apakah kegunaan jam?",
                            new List<string>
                            {
                                "Mengukur berat",
                                "Menunjukkan masa",
                                "Mengukur panjang",
                                "Mengukur suhu",
                            },
                            1
                        ),
                        new Question(
                            "Apakah kenderaan yang bergerak di udara?",
                            new List<string>
                            {
                                "Kapal layar",
                                "Kapal terbang",
                                "Bas",
                                "Kereta api",
                            },
                            1
                        ),
                        new Question(
                            "Radio digunakan untuk…",
                            new List<string>
                            {
                                "Menonton video",
                                "Mendengar muzik",
                                "Menyimpan gambar",
                                "Menulis surat",
                            },
                            1
                        ),
                        new Question(
                            "Kalkulator digunakan untuk…",
                            new List<string>
                            {
                                "Membaca buku",
                                "Mengira nombor",
                                "Mengukur suhu",
                                "Melukis gambar",
                            },
                            1
                        ),
                        new Question(
                            "Lampu suluh digunakan untuk…",
                            new List<string>
                            {
                                "Memasak nasi",
                                "Menerangi kawasan gelap",
                                "Menyiram pokok",
                                "Mengukur jarak",
                            },
                            1
                        ),
                        new Question(
                            "Bas digunakan untuk…",
                            new List<string>
                            {
                                "Mengangkat barang berat",
                                "Mengangkut ramai penumpang",
                                "Menggali tanah",
                                "Membina rumah",
                            },
                            1
                        ),
                        new Question(
                            "Alat yang digunakan untuk mengukur suhu ialah…",
                            new List<string> { "Jam", "Termometer", "Kalkulator", "Peti sejuk" },
                            1
                        ),
                        new Question(
                            "Kenderaan di air dipanggil…",
                            new List<string> { "Bas", "Bot", "Kapal terbang", "Kereta" },
                            1
                        ),
                        new Question(
                            "Apakah fungsi kipas elektrik?",
                            new List<string>
                            {
                                "Memasak nasi",
                                "Menyejukkan udara",
                                "Membersihkan rumah",
                                "Mengukur suhu",
                            },
                            1
                        ),
                        new Question(
                            "Telefon pintar boleh digunakan untuk…",
                            new List<string>
                            {
                                "Mengukur panjang",
                                "Menghantar mesej",
                                "Menyapu sampah",
                                "Memotong kayu",
                            },
                            1
                        ),
                        new Question(
                            "Mesin rumput digunakan untuk…",
                            new List<string>
                            {
                                "Menyiram pokok",
                                "Memotong rumput",
                                "Mengangkat tanah",
                                "Menanam bunga",
                            },
                            1
                        ),
                        new Question(
                            "Apakah teknologi yang digunakan untuk memasak nasi?",
                            new List<string>
                            {
                                "Blender",
                                "Periuk nasi elektrik",
                                "Peti sejuk",
                                "Mesin basuh",
                            },
                            1
                        ),
                    },
                },
                //Level 8: Bumi dan Angkasa Lepas
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Planet tempat kita tinggal ialah…",
                            new List<string> { "Marikh", "Bumi", "Zuhal", "Musytari" },
                            1
                        ),
                        new Question(
                            "Apakah yang memberi kita cahaya pada waktu siang?",
                            new List<string> { "Bulan", "Matahari", "Bintang", "Lampu" },
                            1
                        ),
                        new Question(
                            "Bulan dapat dilihat dengan jelas pada…",
                            new List<string>
                            {
                                "Waktu siang",
                                "Waktu malam",
                                "Waktu petang",
                                "Waktu pagi",
                            },
                            1
                        ),
                        new Question(
                            "Apakah bentuk Bumi?",
                            new List<string> { "Segi empat", "Bulat", "Tiga segi", "Lonjong" },
                            1
                        ),
                        new Question(
                            "Bintang kelihatan…",
                            new List<string>
                            {
                                "Sepanjang masa",
                                "Pada waktu malam",
                                "Pada waktu siang",
                                "Pada waktu petang",
                            },
                            1
                        ),
                        new Question(
                            "Apakah sumber cahaya semula jadi di angkasa?",
                            new List<string> { "Lampu suluh", "Matahari", "Pelita", "Lilin" },
                            1
                        ),
                        new Question(
                            "Apakah yang mengelilingi Bumi?",
                            new List<string> { "Bintang", "Bulan", "Matahari", "Awan" },
                            1
                        ),
                        new Question(
                            "Planet berwarna merah dikenali sebagai…",
                            new List<string> { "Zuhrah", "Marikh", "Musytari", "Uranus" },
                            1
                        ),
                        new Question(
                            "Apakah yang memberi kita haba?",
                            new List<string> { "Bulan", "Matahari", "Bintang", "Lampu" },
                            1
                        ),
                        new Question(
                            "Arah terbit matahari ialah dari…",
                            new List<string> { "Barat", "Timur", "Utara", "Selatan" },
                            1
                        ),
                        new Question(
                            "Apakah yang berlaku pada siang hari?",
                            new List<string>
                            {
                                "Matahari terbenam",
                                "Matahari bersinar",
                                "Bintang bersinar",
                                "Bulan kelihatan",
                            },
                            1
                        ),
                        new Question(
                            "Apakah yang berlaku pada malam hari?",
                            new List<string>
                            {
                                "Matahari bersinar",
                                "Bintang dan bulan kelihatan",
                                "Matahari terbit",
                                "Hujan turun",
                            },
                            1
                        ),
                        new Question(
                            "Apakah yang menutupi sebahagian besar permukaan Bumi?",
                            new List<string> { "Gunung", "Air", "Padang pasir", "Hutan" },
                            1
                        ),
                        new Question(
                            "Kawasan tanah yang luas dan tinggi dipanggil…",
                            new List<string> { "Pantai", "Gunung", "Tasik", "Sungai" },
                            1
                        ),
                        new Question(
                            "Sungai mengalir dari…",
                            new List<string>
                            {
                                "Gunung ke laut",
                                "Gunung ke laut",
                                "Laut ke gunung",
                                "Tasik ke padang pasir",
                            },
                            1
                        ),
                        new Question(
                            "Apakah lapisan gas yang menyelubungi Bumi?",
                            new List<string> { "Hujan", "Atmosfera", "Awan", "Angin" },
                            1
                        ),
                        new Question(
                            "Apakah yang mengelilingi Matahari?",
                            new List<string> { "Bulan sahaja", "Planet", "Gunung", "Laut" },
                            1
                        ),
                        new Question(
                            "Planet terbesar dalam sistem suria ialah…",
                            new List<string> { "Zuhrah", "Musytari", "Marikh", "Uranus" },
                            1
                        ),
                        new Question(
                            "Apakah yang membolehkan kita bernafas di Bumi?",
                            new List<string> { "Hujan", "Udara", "Cahaya", "Awan" },
                            1
                        ),
                        new Question(
                            "Siapakah yang menghantar kapal angkasa ke angkasa lepas?",
                            new List<string> { "Nelayan", "Angkasawan", "Petani", "Doktor" },
                            1
                        ),
                    },
                },
                // Level 9: Teknologi
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Apakah maksud teknologi?",
                            new List<string>
                            {
                                "Benda hidup",
                                "Alat atau kaedah untuk memudahkan kerja",
                                "Cuaca",
                                "Gunung",
                            },
                            1
                        ),
                        new Question(
                            "Contoh teknologi dalam rumah ialah…",
                            new List<string> { "Batu", "Mesin basuh", "Pokok", "Bantal" },
                            1
                        ),
                        new Question(
                            "Alat untuk bercakap jarak jauh ialah…",
                            new List<string> { "Televisyen", "Telefon", "Peti sejuk", "Kipas" },
                            1
                        ),
                        new Question(
                            "Apakah kegunaan komputer?",
                            new List<string>
                            {
                                "Menyimpan makanan",
                                "Mencari maklumat dan membuat kerja",
                                "Membersihkan lantai",
                                "Memasak",
                            },
                            1
                        ),
                        new Question(
                            "Kenderaan yang bergerak di atas jalan raya ialah…",
                            new List<string> { "Kapal terbang", "Kereta", "Kapal layar", "Roket" },
                            1
                        ),
                        new Question(
                            "Basikal digunakan untuk…",
                            new List<string>
                            {
                                "Menyapu lantai",
                                "Bergerak dari satu tempat ke tempat lain",
                                "Menggali tanah",
                                "Memotong kayu",
                            },
                            1
                        ),
                        new Question(
                            "Mesin basuh digunakan untuk…",
                            new List<string>
                            {
                                "Memasak nasi",
                                "Mencuci pakaian",
                                "Membersihkan lantai",
                                "Mengeringkan rambut",
                            },
                            1
                        ),
                        new Question(
                            "Alat untuk mengukur suhu badan ialah…",
                            new List<string> { "Kompas", "Termometer", "Jam", "Kalkulator" },
                            1
                        ),
                        new Question(
                            "Lampu suluh digunakan untuk…",
                            new List<string>
                            {
                                "Mengukur masa",
                                "Memberi cahaya",
                                "Membersihkan bilik",
                                "Menyimpan makanan",
                            },
                            1
                        ),
                        new Question(
                            "Apakah teknologi di sawah padi?",
                            new List<string>
                            {
                                "Telefon pintar",
                                "Mesin menuai padi",
                                "Mesin basuh",
                                "Kereta api",
                            },
                            1
                        ),
                        new Question(
                            "Peti sejuk digunakan untuk…",
                            new List<string>
                            {
                                "Mengeringkan baju",
                                "Menyimpan makanan agar tahan lama",
                                "Memanaskan makanan",
                                "Menghitung nombor",
                            },
                            1
                        ),
                        new Question(
                            "Televisyen digunakan untuk…",
                            new List<string>
                            {
                                "Menyapu lantai",
                                "Menonton rancangan",
                                "Mengukur suhu",
                                "Menjahit baju",
                            },
                            1
                        ),
                        new Question(
                            "Kipas digunakan untuk…",
                            new List<string>
                            {
                                "Memanaskan badan",
                                "Menyejukkan badan",
                                "Mengukur masa",
                                "Menanam pokok",
                            },
                            1
                        ),
                        new Question(
                            "Alat yang digunakan untuk mengambil gambar ialah…",
                            new List<string> { "Radio", "Kamera", "Lampu", "Kipas" },
                            1
                        ),
                        new Question(
                            "Kapal terbang digunakan untuk…",
                            new List<string>
                            {
                                "Menyapu lantai",
                                "Terbang membawa penumpang",
                                "Menyiram pokok",
                                "Menggali tanah",
                            },
                            1
                        ),
                        new Question(
                            "Kereta api digunakan untuk…",
                            new List<string>
                            {
                                "Menghantar surat",
                                "Mengangkut penumpang dan barang",
                                "Mengukur masa",
                                "Memotong kayu",
                            },
                            1
                        ),
                        new Question(
                            "Radio digunakan untuk…",
                            new List<string>
                            {
                                "Menyapu lantai",
                                "Mendengar lagu dan berita",
                                "Memasak",
                                "Mengukur suhu",
                            },
                            1
                        ),
                        new Question(
                            "Alat untuk memotong rumput ialah…",
                            new List<string>
                            {
                                "Pemanggang",
                                "Mesin pemotong rumput",
                                "Mesin basuh",
                                "Kipas",
                            },
                            1
                        ),
                        new Question(
                            "Robot digunakan untuk…",
                            new List<string>
                            {
                                "Menyiram pokok sahaja",
                                "Membantu melakukan kerja",
                                "Mengukur masa",
                                "Mengukur suhu",
                            },
                            1
                        ),
                        new Question(
                            "Contoh teknologi moden ialah…",
                            new List<string>
                            {
                                "Batu kapak",
                                "Telefon pintar",
                                "Lampu minyak tanah",
                                "Kereta lembu",
                            },
                            1
                        ),
                    },
                },
                //Level 10: Bumi dan Angkasa
                new Levels
                {
                    questions = new List<Question>
                    {
                        new Question(
                            "Planet yang kita diami ialah…",
                            new List<string> { "Marikh", "Bumi", "Zuhal", "Musytari" },
                            1
                        ),
                        new Question(
                            "Matahari memberi kita…",
                            new List<string> { "Air", "Cahaya dan haba", "Angin", "Hujan" },
                            1
                        ),
                        new Question(
                            "Bulan dapat dilihat pada waktu…",
                            new List<string> { "Pagi", "Malam", "Petang", "Tengah hari" },
                            1
                        ),
                        new Question(
                            "Bumi mempunyai…",
                            new List<string>
                            {
                                "Bentuk segitiga",
                                "Bentuk bulat seperti sfera",
                                "Bentuk segi empat",
                                "Bentuk silinder",
                            },
                            1
                        ),
                        new Question(
                            "Matahari terbit di…",
                            new List<string> { "Barat", "Timur", "Selatan", "Utara" },
                            1
                        ),
                        new Question(
                            "Apakah sumber cahaya semula jadi pada siang hari?",
                            new List<string> { "Bulan", "Matahari", "Lampu", "Lilin" },
                            1
                        ),
                        new Question(
                            "Bulan mendapat cahaya daripada…",
                            new List<string> { "Bumi", "Matahari", "Bintang", "Angin" },
                            1
                        ),
                        new Question(
                            "Planet terbesar dalam sistem suria ialah…",
                            new List<string> { "Zuhal", "Musytari", "Utarid", "Neptun" },
                            1
                        ),
                        new Question(
                            "Planet yang paling hampir dengan Matahari ialah…",
                            new List<string> { "Zuhrah", "Utarid", "Marikh", "Bumi" },
                            1
                        ),
                        new Question(
                            "Malam berlaku apabila…",
                            new List<string>
                            {
                                "Matahari berada di atas kita",
                                "Bumi membelakangi Matahari",
                                "Bulan bergerak",
                                "Hujan turun",
                            },
                            1
                        ),
                        new Question(
                            "Siang berlaku apabila…",
                            new List<string>
                            {
                                "Bumi membelakangi Matahari",
                                "Bahagian Bumi menghadap Matahari",
                                "Bulan menghadap Matahari",
                                "Hujan turun",
                            },
                            1
                        ),
                        new Question(
                            "Planet bercincin ialah…",
                            new List<string> { "Marikh", "Zuhal", "Bumi", "Neptun" },
                            1
                        ),
                        new Question(
                            "Angkasa dipenuhi dengan…",
                            new List<string>
                            {
                                "Pokok",
                                "Bintang, planet, dan bulan",
                                "Rumah",
                                "Jalan",
                            },
                            1
                        ),
                        new Question(
                            "Orbit bermaksud…",
                            new List<string>
                            {
                                "Bentuk bintang",
                                "Laluan peredaran planet mengelilingi Matahari",
                                "Pergerakan angin",
                                "Bentuk bulan",
                            },
                            1
                        ),
                        new Question(
                            "Bulan mengelilingi…",
                            new List<string> { "Matahari", "Bumi", "Marikh", "Zuhrah" },
                            1
                        ),
                        new Question(
                            "Kegunaan Matahari kepada tumbuhan ialah…",
                            new List<string>
                            {
                                "Menyimpan air",
                                "Membantu membuat makanan",
                                "Memotong daun",
                                "Mengukur masa",
                            },
                            1
                        ),
                        new Question(
                            "Bintang kelihatan…",
                            new List<string>
                            {
                                "Pada siang hari",
                                "Pada malam hari",
                                "Ketika hujan",
                                "Pada waktu petang sahaja",
                            },
                            1
                        ),
                        new Question(
                            "Teleskop digunakan untuk…",
                            new List<string>
                            {
                                "Memasak",
                                "Melihat objek di angkasa",
                                "Mengukur masa",
                                "Menyiram pokok",
                            },
                            1
                        ),
                        new Question(
                            "Apakah bentuk bulan yang boleh dilihat di langit?",
                            new List<string>
                            {
                                "Sfera sahaja",
                                "Pelbagai bentuk seperti separuh dan penuh",
                                "Segitiga",
                                "Silinder",
                            },
                            1
                        ),
                        new Question(
                            "Apakah nama sistem yang mengandungi Matahari, planet, dan satelit?",
                            new List<string>
                            {
                                "Sistem air",
                                "Sistem suria",
                                "Sistem bumi",
                                "Sistem angin",
                            },
                            1
                        ),
                    },
                },
            }
        );
    }

    // Update is called once per frame
    void Update() { }
}
