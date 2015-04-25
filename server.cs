//StudGuard made by Sarg3 {41072}
//notify the users that StudGuard is used in a server
function GameConnection::AutoAdminCheck(%this)
	{
		parent::AutoAdminCheck(%this);
		messageClient(%this,'',"\c3This server is currently running StudGuard");

//executing stuff

exec("./commands/adminc/chelp")
exec("./commands/adminc/listitems.cs")
exec("./commands/chat/fixcaps.cs")
