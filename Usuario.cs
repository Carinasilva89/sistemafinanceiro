public class Usuario{

private string? nome;
private string? cpf;
private string? email;
private int? id;
private string? qualuercoisa;
public Usuario(){

}
public Usuario(string nome, string cpf, string email, int id){
    this.nome = nome;
    this.cpf = cpf;
    this.email = email;
    this.id = id;
}

public string getNome(){
    return this.nome;
}
public void setNome(string nome){
    this.nome = nome;
}

public string getCpf(){
    return this.cpf;
}
public void setCpf(string cpf){
    this.cpf = cpf;
}

public string getEmail(){
    return this.email;
}
public void setEmail(string email){
    this.email = email;
}

public int getId(){
    return (int) this.id;
}
public void setId(int id){
    this.id = id;
}







}