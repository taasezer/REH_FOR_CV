#include <iostream>
#include <pqxx/pqxx>

int main() {
    try {
        pqxx::connection conn("host=db user=kullanici password=sifre dbname=rehber");
        pqxx::work txn(conn);
        txn.exec(
            "INSERT INTO kisi (isim, eposta, telefon, adres) "
            "VALUES ('Mehmet Demir', 'mehmet@example.com', '5559876543', 'İstanbul, Türkiye')"
        );
        txn.commit();
        std::cout << "Kişi eklendi." << std::endl;
    } catch (const std::exception &e) {
        std::cerr << "Hata: " << e.what() << std::endl;
        return 1;
    }
    return 0;
}
