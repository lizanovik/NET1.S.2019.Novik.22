# NET1.S.2019.Novik.22
<h2><a id="user-content-задачи-deadline--" class="anchor" aria-hidden="true" href="#задачи-deadline--"><svg class="octicon octicon-link" viewBox="0 0 16 16" version="1.1" width="16" height="16" aria-hidden="true"><path fill-rule="evenodd" d="M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z"></path></svg></a>Задачи (deadline -)</h2>
<p>В текстовом файле построчно хранится информация об URL-адресах, представленных в виде</p>
<p><a target="_blank" rel="noopener noreferrer" href="https://github.com/AnzhelikaKravchuk/.NET-Training.-Spring-2019/blob/master/Pictures/Scheme.png"><img src="https://github.com/AnzhelikaKravchuk/.NET-Training.-Spring-2019/raw/master/Pictures/Scheme.png" alt="Scheme" style="max-width:100%;"></a></p>
<p>где сегмент parameters - это набор пар вида key=value, при этом сегменты URL‐path и parameters  или сегмент parameters могут отсутствовать.
Разработать (в соответствии в принципами SOLID) систему типов для экспорта данных, полученных на основе разбора информации текстового файла в XML-документ по следующему правилу, например, для текстового файла с URL-адресами</p>
<ul>
<li><a href="https://github.com/AnzhelikaKravchuk?tab=repositories">https://github.com/AnzhelikaKravchuk?tab=repositories</a></li>
<li><a href="https://github.com/AnzhelikaKravchuk/2017-2018.MMF.BSU">https://github.com/AnzhelikaKravchuk/2017-2018.MMF.BSU</a></li>
<li><a href="https://habrahabr.ru/company/it-grad/blog/341486/" rel="nofollow">https://habrahabr.ru/company/it-grad/blog/341486/</a></li>
</ul>
<p>результирующим является XML-документ вида (можно использовать любую XML технологию без ограничений).</p>
<p><a target="_blank" rel="noopener noreferrer" href="https://github.com/AnzhelikaKravchuk/.NET-Training.-Spring-2019/blob/master/Pictures/XML.Task.png"><img src="https://github.com/AnzhelikaKravchuk/.NET-Training.-Spring-2019/raw/master/Pictures/XML.Task.png" alt="XML-результат" style="max-width:100%;"></a></p>
<p>Для тех URL-адресов, которые не совпадают с указанным паттерном, залогировать информацию (предусмотреть возможность замены лог-фреймворка, в качестве дефолтного использовать NLog), отметив указанные строки, как необработанные. Для работы с URL можно использовать <a href="https://msdn.microsoft.com/ru-ru/library/system.uri(v=vs.110).aspx" rel="nofollow">Uri Class</a>.</p>
<p>Продемонстрировать работу на примере консольного приложения.</p>
<p>При реализации solution-а для организации проектов использовать Stairway-паттерн.</p>
<p>Для разрешения зависимостей использовать Ninject.</p>
<p>Для тетирования основой функциональности использовать NUnit и Moq фреймворки.</p>
<p>При реализации системы типов учитывать возможность их использования в случае, когда в исходном текстовом файле информация об URL-адресах изменится на другую, иерархически представимую информацию.</p>
