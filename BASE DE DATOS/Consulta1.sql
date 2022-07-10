create proc sp_registroCliente(
@usuario varchar(100),
@Contraseña varchar(100),
@Registrado bit output,
@Mensaje varchar(100) output
)
as
----------
update 

if (not exists(select * from empleado where usuario = @usuario)
begin 
 insert into GymisLife (usuario, contraseña) values (@Usuario, @Contraseña)
  set @Registrado = 1
  set @Mensaje = 'Usuario registrado'
  end

  else
  begin
	set @Registrado =0
	set @Mensaje = 'usuario existe'
	end
end

drop sp_registroCliente

exec sp_registroCliente